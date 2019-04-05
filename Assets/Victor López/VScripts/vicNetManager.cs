using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class vicNetManager : NetworkManager {
	//public List<OnlinePlayersLogics> OnlineStats = new List<OnlinePlayersLogics>();

	public void StartHosting(){
		SetPort();
		NetworkManager.singleton.StartHost();
	}

	public void JoinGame(){
		SetIpAdress();
		SetPort();
		NetworkManager.singleton.StartClient();
	}


	void SetIpAdress(){
		string ipAdress=GameObject.Find("InputFieldAdress").transform.Find("Text").GetComponent<Text>().text;
		NetworkManager.singleton.networkAddress = ipAdress;
	}	

	void SetPort(){
		NetworkManager.singleton.networkPort = 7777;
	}

	void OnLevelWasLoaded(int level){
		if(level == 6){
			SetUpOnlineMenuButtons();
		}

		if(level == 16 || level == 6){
			Debug.Log("Conected");
		}else{NetworkManager.singleton.StopHost();}
	}

	public void SetUpOnlineMenuButtons(){
		GameObject.Find("btn_CreateGame").GetComponent<Button>().onClick.AddListener(StartHosting);
		GameObject.Find("btn_JoinGame").GetComponent<Button>().onClick.AddListener(JoinGame);
	}

	public void SetUpDisconectButton(){
		GameObject.Find("btn_disconect").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btn_disconect").GetComponent<Button>().onClick.AddListener(NetworkManager.singleton.StopHost);
	}

}
