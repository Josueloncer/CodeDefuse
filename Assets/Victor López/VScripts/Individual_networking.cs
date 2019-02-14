using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Individual_networking : NetworkBehaviour{


	public GameObject player;
	//public GameObject[] characterModel;

	public override void OnStartLocalPlayer(){
		GetComponent<Movement_OnlinePlayerPrueba>().enabled = true;
		player.SetActive(true);

		/*foreach(GameObject go in characterModel){
			go.SetActive(false);
		}*/
	}
}
