using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference:
//http://answers.unity3d.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html


public class Obstacle : MonoBehaviour {

	public float delta = 10f;
	public float speed = 20f;
	private Vector3 startPos;

	void Start(){

		startPos = transform.position;
	}

	void Update(){
		Vector3 v = startPos;
		v.z += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}

}
