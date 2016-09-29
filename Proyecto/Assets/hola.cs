using UnityEngine;
using System.Collections;

public class hola : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) 
		{	
			gameObject.GetComponent<Renderer>().material.color=Color.red;
		}

	}
}
