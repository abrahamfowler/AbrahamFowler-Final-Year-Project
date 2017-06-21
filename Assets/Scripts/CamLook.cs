using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// REFERENCE:
// The original source for this code file is: https://www.youtube.com/watch?v=blO039OzUZc&t=914

public class CamLook : MonoBehaviour {

	Vector2 mouseLook;//This keeps track of how much movement the camera has made
	Vector2 smoothV;//Helps to smooth down the movement, similar to multiplying movements to Time.delta

	public float sensitiviy = 5.0f; //how much you have to move your mouse to actually get any movement out of the player 
	public float smoothing = 2.0f; //the smoothness of the movement

	GameObject character;

	void Start(){
		character = this.transform.parent.gameObject;
		//Allowing us to turn and move around the environment in different directions
	}


	void Update () {
		
		//This is the mouse movement and constantly updates every movement 
		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));

		//Gets you the change in of the mouse movement since the
		//last update
		md = Vector2.Scale(md, new Vector2(sensitiviy * smoothing, sensitiviy * smoothing));

		//The movement of mouse is multiplied by the sensitivity and the smoothing values 
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		// Linear interpolation of movement - instead of instantly moving the camera from one direction to another 
		// it will move smoothly between two points
		smoothV.y = Mathf.Lerp (smoothV.y, md.y,1f / smoothing);

		mouseLook += smoothV;

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);

		//Rotating around the character's up rather than the camera's up
		//to make the whole character move
		character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
	}
}

