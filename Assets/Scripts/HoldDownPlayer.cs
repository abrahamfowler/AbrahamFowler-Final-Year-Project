using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//REFERENCE:
// The original source for this code file is: https://www.youtube.com/watch?v=AfwmRYQRsbg&t=1068s  


public class HoldDownPlayer : MonoBehaviour {


	void OnTriggerEnter(Collider col){ 
		col.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider col){
		col.transform.parent = null;
	}
}
