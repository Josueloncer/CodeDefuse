using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface_Behaviours : MonoBehaviour {

	public string _WhichScene;
	public GameObject[] Main_btns, Dificult_btns, Multiplayer_btns, OnlineM_btns;
	public GameObject Back_btn;
	bool _MainB = true, _Difi_SingPB = false, _Difi_MultPLB = false, _MultB = false, _OnliB = false;

	void Start(){
		MainButtonsOn();
	}
	//Cierra la escena actual y va a la escena especificada en el string.
	public void GoToScene(){
		SceneManager.LoadScene(_WhichScene, LoadSceneMode.Single);
	}

	//Abre(Añade) encima la escena especificada en el string.
	public void AddScene(){
		SceneManager.LoadScene(_WhichScene, LoadSceneMode.Additive);
	}

	//Cierra la escena especificada en el string.
	public void CloseScene(){
		//SceneManager.UnloadScene(_WhichScene);
		SceneManager.UnloadSceneAsync(_WhichScene);
	}

	public void MainButtonsOn(){
		//Desactiva Botones que no son Main.
		_MainB = true;
		if(Back_btn != null)Back_btn.SetActive(false);
		Activate_Or_Deactivate_button(Main_btns, "Btns_Main", true);
		Activate_Or_Deactivate_button(Dificult_btns, "Btns_Dificulty", false);
		Activate_Or_Deactivate_button(Multiplayer_btns, "Btns_Multiplayer", false);
		Activate_Or_Deactivate_button(OnlineM_btns, "Btns_OnlineM", false);
	}

	public void SinglePlayerOn(){
		_Difi_SingPB = true;
		if(Back_btn != null)Back_btn.SetActive(true);
		Activate_Or_Deactivate_button(Main_btns, "Btns_Main", false);
		Activate_Or_Deactivate_button(Dificult_btns, "Btns_Dificulty", true);
		Activate_Or_Deactivate_button(Multiplayer_btns, "Btns_Multiplayer", false);
		Activate_Or_Deactivate_button(OnlineM_btns, "Btns_OnlineM", false);
	}

	public void MultiplayerOn(){
		_MultB = true;
		if(Back_btn != null)Back_btn.SetActive(true);
		Activate_Or_Deactivate_button(Main_btns, "Btns_Main", false);
		Activate_Or_Deactivate_button(Dificult_btns, "Btns_Dificulty", false);
		Activate_Or_Deactivate_button(Multiplayer_btns, "Btns_Multiplayer", true);
		Activate_Or_Deactivate_button(OnlineM_btns, "Btns_OnlineM", false);
	}

	public void MultiplayerOnlineOn(){
		_OnliB = true;
		if(Back_btn != null)Back_btn.SetActive(true);
		Activate_Or_Deactivate_button(Main_btns, "Btns_Main", false);
		Activate_Or_Deactivate_button(Dificult_btns, "Btns_Dificulty", false);
		Activate_Or_Deactivate_button(Multiplayer_btns, "Btns_Multiplayer", false);
		Activate_Or_Deactivate_button(OnlineM_btns, "Btns_OnlineM", true);
	}

	public void MultiplayerLocalOn(){
		_Difi_MultPLB = true;
		if(Back_btn != null)Back_btn.SetActive(true);
		Activate_Or_Deactivate_button(Main_btns, "Btns_Main", false);
		Activate_Or_Deactivate_button(Dificult_btns, "Btns_Dificulty", true);
		Activate_Or_Deactivate_button(Multiplayer_btns, "Btns_Multiplayer", false);
		Activate_Or_Deactivate_button(OnlineM_btns, "Btns_OnlineM", false);
	}

	public void GoBackButton(){
		if(_Difi_SingPB || _MultB && !_OnliB && !_Difi_MultPLB){
			MainButtonsOn();
			_MainB = true;
			_Difi_SingPB = false;
			_MultB = false;
		}else if(_OnliB && _MultB){
			MultiplayerOn();
			_OnliB = false;
		}else if(_Difi_MultPLB && _MultB){
			MultiplayerOn();
			_Difi_MultPLB = false;
		}
	}

	void Activate_Or_Deactivate_button(GameObject[] GameObjectArray, string TagButtons, bool activateOrDeactivate){
		if (GameObjectArray == null){
            GameObjectArray = GameObject.FindGameObjectsWithTag(TagButtons);
		}
		foreach(GameObject ActualButtons in GameObjectArray){
			ActualButtons.SetActive(activateOrDeactivate);
		}
	}
}
