
// REFERENCE:
// This source was used to rotate the collectible coin and to trigger audio 
// when the collectible coin is collected: https://www.youtube.com/watch?v=hoY1eWqDo5s&t=611s


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
