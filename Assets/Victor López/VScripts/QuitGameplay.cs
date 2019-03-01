using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGameplay : MonoBehaviour {

	public string _WhichScene;
	
public void quitScene(){
		SceneManager.LoadScene(_WhichScene, LoadSceneMode.Single);
	}
}
