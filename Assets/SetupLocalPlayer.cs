using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {
    




	// Use this for initialization
	void Start () {
		/*if(isLocalPlayer)
		{
			GetComponent<LogicaVer4>().enabled = true;
		}else
		{
			GetComponent<LogicaVer4>().enabled = false;
		}*/
	}
	
	public void GameOver()
	{
		Debug.LogWarning("GameOver");
	}
}
