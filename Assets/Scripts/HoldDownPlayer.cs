using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - Reference: 
// - https://www.youtube.com/watch?v=dXAVAA8xXRs
// - https://docs.unity3d.com/Manual/UnityOverview.html


public class HoldDownPlayer : MonoBehaviour {


	void OnTriggerEnter(Collider col){ 
		col.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider col){
		col.transform.parent = null;
	}
}
