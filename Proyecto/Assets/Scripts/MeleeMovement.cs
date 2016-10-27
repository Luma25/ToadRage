using UnityEngine;
using System.Collections;

public class MeleeMovement : MonoBehaviour 
{
	public Animator anim;
	public Rigidbody rbody;
	public Transform trnsfrm;
	public float speedH = 50, speedV = 50, runSpeed = 100;
	float InputH, InputV, moveZ, turn;
	bool Run, punch, kick;
	float move;

	void Start () 
	{
		anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();
		trnsfrm = GetComponent<Transform> ();
		Run = false;
		punch = kick = true;
	}

	void Update ()
	{
		if(Input.GetKey(KeyCode.LeftShift))
		{
			Run = true; 
		}
		else
		{
			Run = false;
		}

		InputH = Input.GetAxis ("Horizontal");
		InputV = Input.GetAxis ("Vertical");

		anim.SetFloat ("InputH", InputH);
		anim.SetFloat ("InputV", InputV);
		anim.SetBool ("Run", Run);

		if(Run)
		{
			move = InputV * runSpeed * Time.deltaTime;
		}
		else
		{
			move = InputV * speedV * Time.deltaTime;
		}

<<<<<<< HEAD
		if (Input.GetKey (KeyCode.Space)) 
		{
			anim.SetBool ("Jump", true);	
		} 
		else 
		{ 
			anim.SetBool ("Jump", false);
		}

=======
>>>>>>> origin/movimientos-dummy
		Debug.Log ("m: " + move);

		float moveX = Mathf.Sin (trnsfrm.eulerAngles.y * (Mathf.PI / 180)) * move;
		float moveZ2 = Mathf.Cos (trnsfrm.eulerAngles.y * (Mathf.PI / 180)) * move;

		Debug.Log ("rot: " + transform.rotation.y + ", " + Mathf.Sin(trnsfrm.eulerAngles.y * (Mathf.PI/180)));
		Debug.Log ("mx, mz: " + moveX + ", " + moveZ2);

		turn = InputH * speedH * Time.deltaTime;

		rbody.velocity = new Vector3 (moveX, 0, moveZ2);
		trnsfrm.Rotate(0, turn, 0);


		if(Input.GetKeyDown(KeyCode.A))
		{
			if (punch) 
			{
				punch = false;
				anim.Play ("punchRt", -1, 0f);
			}
			else 
			{
				punch = true;
				anim.Play ("punchLf", -1, 0f);
			}
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			if (kick)
			{
				kick = false;
				anim.Play ("kickRt", -1, 0f);
			}
			else
			{
				kick = true;
				anim.Play ("kickLf", -1, 0f);
			}
		}
	}

	/*
	void Attacked (Collider col)
	{
		Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("HitBox"));

		foreach (Collider c in cols) 
		{
			if (c.transform.parent.parent == transform)
				continue;
		}
	}
	*/
}