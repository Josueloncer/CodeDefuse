using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    public void Control()
    {
        SceneManager.LoadScene("Easy");
    }
}
