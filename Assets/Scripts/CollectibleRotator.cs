
// REFERENCES:
// To rotate the collectible coin I used this source: https://www.youtube.com/watch?v=HlDGSStxuHI 
// To trigger audio when the collectible coin is collected by the player I used this source: https://www.youtube.com/watch?v=hoY1eWqDo5s&t=611s


using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollectibleRotator : MonoBehaviour {
	 
	public float rotateSpeed;
	

	void Update () {
		gameObject.transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
	}



	void OnTriggerEnter(Collider other){
	
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}

}
