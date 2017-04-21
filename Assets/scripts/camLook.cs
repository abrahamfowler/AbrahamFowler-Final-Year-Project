using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLook : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;

	public float sensitiviy = 5.0f;
	public float smoothing = 2.0f;

	GameObject character;

	void Start(){
		character = this.transform.parent.gameObject;
	}

	// Update is called once per frame
	void Update () {
		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));  //Gets x and y coordinates in the 
		//environment and gets the mouseX and mouseY position
		md = Vector2.Scale(md, new Vector2(sensitiviy * smoothing, sensitiviy * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y,1f / smoothing);

		mouseLook += smoothV;

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);//Used to rotate the camera up and down
		character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
	}
}
