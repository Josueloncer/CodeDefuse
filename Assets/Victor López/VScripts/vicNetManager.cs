using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class vicNetManager : NetworkManager {
	bool once = false;

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
		if(level == 2){
			//SetUpMenuSceneButtons();
			once = false;
		}else if(level == 7){
			SetUpDisconectButton();
			OffUtilities.OnlineOn = false;
		}
	}

	public void SetUpOnlineMenuButtons(){
		GameObject.Find("btn_CreateGame").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btn_CreateGame").GetComponent<Button>().onClick.AddListener(StartHosting);

		GameObject.Find("btn_JoinGame").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btn_JoinGame").GetComponent<Button>().onClick.AddListener(JoinGame);
	}

	public void SetUpDisconectButton(){
		GameObject.Find("btn_disconect").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btn_disconect").GetComponent<Button>().onClick.AddListener(NetworkManager.singleton.StopHost);
	}

	void Update(){
		if(OffUtilities.OnlineOn == true && once == false){
			SetUpOnlineMenuButtons();
			once = true;
		}
	}
}
