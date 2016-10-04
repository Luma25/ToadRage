using System.Collections;
using UnityEngine;

[RequireComponent (typeof (CharacterController))]
public class ThirdPersonWithMouse : MonoBehaviour {

	CharacterController characterController;
	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 2.0f;
	public float jumpSpeed = 10.0f;
	public bool isGrounded;

	void Start () {

		characterController = GetComponent<CharacterController> ();
	}

	void FixedUpdate () {
		isGrounded = characterController.isGrounded;

		//Rotation
		float rotY = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotY, 0);

		//Movement
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float slideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;
		Vector3 speed = new Vector3 (slideSpeed, 0, forwardSpeed);


		speed = transform.rotation * speed;
		characterController.Move (speed * Time.deltaTime);
	}
}