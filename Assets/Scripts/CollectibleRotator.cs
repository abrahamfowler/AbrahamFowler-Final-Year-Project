using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - Reference:
//- https://www.youtube.com/watch?v=HlDGSStxuHI

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
