using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public int speed;
	// Update is called once per frame
	void Update () {
		//Rotates Cubes. Multiply by deltaTime to be smooth and framerate independent 
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
	}
}
