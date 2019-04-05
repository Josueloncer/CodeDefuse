using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface_Behaviours : MonoBehaviour {

    public string _WhichScene, SINGLEdificultSceneSelection, MULTIdificultSceneSelection;

    public GameObject[] Main_btns, Dificult_btns, Multiplayer_btns, OnlineM_btns, Winner_Interface;
	public GameObject Back_btn;
	public static bool _MainB = true, _Difi_SingPB = false, _Difi_MultPLB = false, _MultB = false, _OnliB = false, winUP = false;

	void Start(){
		MainButtonsOn();
		for(int i = 0; i < Winner_Interface.Length; i++){
			Winner_Interface[i].SetActive(false);
		}
	}

	void Update(){
		if(OnlinePlayersLogics.winUP == true){
			ShowWinner();
			winUP = false;
		}
	}
	//Cierra la escena actual y va a la escena especificada en el string.
	public void GoToScene(){
		SceneManager.LoadScene(_WhichScene, LoadSceneMode.Single);
	}

	public void ShowWinner(){
		for(int i = 0; i < Winner_Interface.Length; i++){
			Winner_Interface[i].SetActive(true);
		}
	}

    public void DificultySelection()
    {

        if (_Difi_SingPB)
        {
            SceneManager.LoadScene(SINGLEdificultSceneSelection, LoadSceneMode.Single);
        }
        else if (_Difi_MultPLB)
        {
            SceneManager.LoadScene(MULTIdificultSceneSelection, LoadSceneMode.Single);
        }
    }

    //Abre(Añade) encima la escena especificada en el 
    public void AddScene(){
		SceneManager.LoadScene(_WhichScene, LoadSceneMode.Additive);
	}

	public void ReloadScene(){
		 Application.LoadLevel(Application.loadedLevel);
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



    /*public void easy()
    {
        Application.LoadLevel("Easy");
    }


    public void Normal()
    {
        Application.LoadLevel("Normal");
    }

    public void Hard()
    {
        Application.LoadLevel("Hard");
    }

    public void Xtreme()
    {
        Application.LoadLevel("X-Treme");
    }*/
}
