using UnityEngine;
using System.Collections;

public class DummyMovement : MonoBehaviour {

	public Animator anim;
	public Rigidbody rbody;
	public Transform trnsfrm;
	public float speedH = 50, speedV = 50, runSpeed = 100;
	public bool running = false;
	public int distance = 5;
	public bool vuelta = false;
	float InputH, InputV, moveZ, turn;

	void Start () 
	{
		anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();
		trnsfrm = GetComponent<Transform> ();
	}

	void Update ()
	{

		if(Input.GetKey(KeyCode.P))
		{
			anim.Play ("run", -1, 0f);
			running = true;
		}

		if(Input.GetKey(KeyCode.O))
		{
			anim.Play ("Idle", -1, 0f);
			running = false;
		}

		if(running) 
		{
			rbody.velocity = new Vector3 (1, 0, 1);
			if (vuelta)
			{
				trnsfrm.Rotate(0, 0, 0);
				distance = distance + 1;
			}
			else 
			{
				trnsfrm.Rotate(0, 180, 0);
				distance = distance - 1;
			}

			if (distance > 20)
			{
				vuelta = false;
			}
			else if(distance < 4)
			{
				vuelta = true;
			}
			
			trnsfrm.position = new Vector3 (4, 0, distance);
		}
		
	}

	

	void Attacked (Collider col)
	{
		Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("HitBox"));

		foreach (Collider c in cols) 
		{
			if (c.transform.parent.parent == transform)
				continue;

			print(c.name);
		}
	}
}