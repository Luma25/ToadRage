using UnityEngine;
using System.Collections;

public class ControladorCamara : MonoBehaviour {

	public GameObject Jugador;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - Jugador.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = Jugador.transform.position + offset;
	}
}