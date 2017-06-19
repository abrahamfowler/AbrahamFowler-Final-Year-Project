using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//REFERENCE: 
//The original source for this script is:  https://www.youtube.com/watch?v=AfwmRYQRsbg&t=1046s


public class MovingPlatform : MonoBehaviour {

	public Transform movePlatform;
	//Initialising the positions of the plaforms
	public Transform pos1; 
	public Transform pos2;
	//Initialising the new 
	public Vector3 newPos;
	public string currentState; //State machine to hold the states for the position
	public float smooth;
	public float resetTime; 

	// Use this for initialization
	void Start () {
		ChangeTarget (); //Creating a function for the change target
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movePlatform.position = Vector3.Lerp (movePlatform.position, newPos, smooth * Time.deltaTime);//Allows the platform to move 
		//smoothly
	}

	void ChangeTarget(){

		if (currentState == "Moving To Position 1") { //Gets the current state of position 1  
			currentState = "Moving To Position 2"; //updates the position its going to
			newPos = pos2.position; //Then it moves to it's new position 
		}

		else if (currentState == "Moving To Position 2") { //Gets the current state of position 2
			currentState = "Moving To Position 1"; //Updates Position 2
			newPos = pos1.position; //then it goes back to Position 1 
		} 

		else if (currentState == "") { // Checks the movement
			currentState = "Moving To Position 2"; //Gets the current state, which is Position 2
			newPos = pos2.position; //
		}
		Invoke ("ChangeTarget", resetTime); //Tells the target to come back at a later time
	}
}
