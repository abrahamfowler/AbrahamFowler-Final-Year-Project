using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - Reference:
// - https://www.youtube.com/watch?v=nBgCeJBMT0k


public class Respawn : MonoBehaviour {

	[SerializeField] private Transform player;
	[SerializeField] private Transform respawnpoint;

	void OnTriggerEnter(Collider other)
	{
		player.transform.position = respawnpoint.transform.position;
	}


}
