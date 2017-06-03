using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		//Find and store refrence to PlayerObject Rigidbody component
		rb = GetComponent<Rigidbody> ();
	}

	// Called before any physics calculation. Physics code goes here
	void FixedUpdate (){
		//Grabs input from player through keyboard
		//Variables record Horizontal and Vertical values which are controlled
		//by keys on the keyboard
		//We'll use this input to add forces to the rigid body and move the player
		//Game object in the scene
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);

	}
}
