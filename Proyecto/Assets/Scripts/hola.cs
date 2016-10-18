using UnityEngine;
using System.Collections;

public class hola : MonoBehaviour {

//	public gameObject[] cilindro;
 	// Use this for initialization
	public int j=0;
	public int k=0;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	GameObject cubeGO = GameObject.Find("Cilindros");
	Transform t = cubeGO.transform;
	int i=0;
	GameObject[] childsG = new GameObject[transform.childCount];

	foreach(Transform child in t) 
		{
    		childsG[i] = child.gameObject;
     		i++;
		}	
		if(k==0)
		{childsG[k].GetComponent<Renderer>().material.color = Color.red;	k=k+1;}

	if (Input.GetKeyDown (KeyCode.RightArrow))
	{	
		if(j==4)
		{
			j=0;
			childsG[j].GetComponent<Renderer>().material.color = Color.red;
			childsG[4].GetComponent<Renderer>().material.color = Color.white;
		}
		else if (j<4)
		{
			j=0;
			childsG[4].GetComponent<Renderer>().material.color = Color.white;
			childsG[j].GetComponent<Renderer>().material.color = Color.red;
			childsG[j-1].GetComponent<Renderer>().material.color = Color.white;
		}
	}

	if (Input.GetKeyDown (KeyCode.LeftArrow))
	{	
		if(j>0)

		{
			j=j-1;
			childsG[j].GetComponent<Renderer>().material.color = Color.red;
			childsG[j+1].GetComponent<Renderer>().material.color = Color.white;

		}

		else if(j==0)
		{

			j=4;
			childsG[0].GetComponent<Renderer>().material.color = Color.white;
			childsG[j].GetComponent<Renderer>().material.color = Color.red;
		}
	}
	if (Input.GetKeyDown (KeyCode.Space))
	{
		j=j+1;
		string level = "Level0";
		string leveln= j.ToString();
		level = level+leveln;
		Application.LoadLevel(level);
	}
	}
}
