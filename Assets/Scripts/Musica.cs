using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Musica : MonoBehaviour {

    public AudioClip musica;
    public GameObject mus;
    AudioSource muss;

    private void Start()
    {
        //muss = GetComponent<AudioSource>();
       // muss.
        
        Scene EcenaActual = SceneManager.GetActiveScene();
        int EA = SceneManager.GetActiveScene().buildIndex;

        switch (EA)
        {

            case 0:

                break;


        }


    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
