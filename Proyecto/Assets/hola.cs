using UnityEngine;
using System.Collections;

public class hola : MonoBehaviour {

//	public gameObject[] cilindro;
 	// Use this for initialization

	void Start () {
	GameObject ParentGameObject = GameObject.FindGameObjectWithTag("Cilindro"); 
	Transform aChild = transform.FindChild( "Cylinder1" );
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.L)) 
		{	
			
		}

	}
}
