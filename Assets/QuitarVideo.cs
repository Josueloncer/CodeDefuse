using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitarVideo : MonoBehaviour
{

    public float T = 46f;
	
	// Update is called once per frame
	void Update ()
    {
        T -= Time.deltaTime * 1;
        if (T <= 0)
        {
            SceneManager.LoadScene("00Main_Menu");
        }
    }
}
