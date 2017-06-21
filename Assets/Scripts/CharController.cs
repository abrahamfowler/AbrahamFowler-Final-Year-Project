//REFERENCES: 
//This source was for controlling the character - https://www.youtube.com/watch?v=blO039OzUZc&t=914  
//This source was used to count points - https://www.youtube.com/watch?v=XtR29MmzuT0&list=PLX2vGYjWbI0Q-s4_lX0h4i2zbZqlg4OfF&index=7
//This source was used to display the score when the game is in play mode - https://www.youtube.com/watch?v=bFSLI2cmYYo&list=PLX2vGYjWbI0Q-s4_lX0h4i2zbZqlg4OfF&index=8

using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;

public class CharController : MonoBehaviour {   	public float speed = 10.0f; 	public int count; 	public Text countText; 	public Text winText;  	void Start (){ 		 		//This will turn off your cursor so that you won't see it on the screen 		// locks its so that it is in the game window 		//	Cursor.lockState = CursorLockMode.Locked; 		//}  		count = 0; 		SetCountText (); 	}   	void Update (){  		//The character itself is a translate 		//The translate will straffe it along the x axis and translate it along the z axis   		//Translation and straffe is both multiplied by deltaTime to ensure it runs smoothly and at the same rate 		float translation = Input.GetAxis ("Vertical") * speed; //Allows the player to go vertically  		float straffe = Input.GetAxis ("Horizontal") * speed; // Allows the player to go horizontally 		translation *= Time.deltaTime; //delta.Time is the time between this update and the time update ran 		straffe *= Time.deltaTime;  		//Translation is the forward and backward movement  		//Staffe does the side movements   		transform.Translate (straffe, 0, translation);   		///if (Input.GetKeyDown ("escape")) //If you press the escape key it will unlock the cursor  		//	Cursor.lockState = CursorLockMode.None; 	} 		  	void OnTriggerEnter(Collider other) { 		if (other.gameObject.CompareTag ("Pick Up")) {//We initialise a tag for the pick up objects 			other.gameObject.SetActive (false); 			count = count + 1; 			SetCountText ();  		}  	}  	void SetCountText (){ 		countText.text = "Score: " + count.ToString (); //Display and update the score 		if (count >= 13) { //Count the 13 pick up objects 			winText.text = "You Win!"; //Display the "You Win" Text when the player collects all the 13 pick up objects 		} 	}  }  
