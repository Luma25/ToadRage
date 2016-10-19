using UnityEngine;
using System.Collections;

public class mov_aleatorio : MonoBehaviour {
	public int life=1;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollision(Collision cl)
	{
		if(cl.gameObject.name=="Audience")
		{
			Destroy(cl.gameObject);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
