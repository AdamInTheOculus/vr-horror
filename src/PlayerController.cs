using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private GameControllerHandler controller;

	// Controller input data
	private float leftAnalogX, leftAnalogY;

	// Player physics data
	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		controller = GetComponent<GameControllerHandler> ();
	}
	
	// Update is called once per frame
	void Update () {
		HandleMovement ();
		HandleActions ();
	}

	/// <summary>
	/// This function executes once a frame. It handles all button presses made by player.
	/// </summary>
	private void HandleActions() {
		if (Input.GetButtonDown (controller.ButtonA)) {
			Debug.Log ("Player pressed A!");
		}
	}

	/// <summary>
	/// This function executes once a frame. It handles all analog stick movements made by player.
	/// </summary>
	private void HandleMovement() {
		// Gives decimal value between -1 and 1
		leftAnalogX = Input.GetAxis (controller.AxisLeftAnalogX);
		leftAnalogY = Input.GetAxis (controller.AxisLeftAnalogY);

		SmoothMovementHandling();
		//RoughMovementHandling();

		Debug.Log("Left Analog X: " + leftAnalogX);
		Debug.Log ("Left Analog Y: " + leftAnalogY);
		transform.position += (Vector3)velocity * Time.deltaTime;
	}


	/// <summary>
	/// Smooths the movement by slowly accelerating and decelerating.
	/// Almost like a "gliding effect".
	/// </summary>
	private void SmoothMovementHandling() {
		var x = leftAnalogX * Time.deltaTime * 150.0f;
		var z = leftAnalogY * Time.deltaTime * 10.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, -z);
	}
}
