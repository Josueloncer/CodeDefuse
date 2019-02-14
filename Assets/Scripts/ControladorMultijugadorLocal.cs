using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMultijugadorLocal : MonoBehaviour {
    

    public void NivelFacil()
    {
        SceneManager.LoadScene("MultiLocalFacil");
    }

    public void NivelNormal()
    {
        SceneManager.LoadScene("MultiLocalNormal");
    }

    public void NivelDificil()
    {
        SceneManager.LoadScene("MultiLocalDificil");
    }

    public void NivelExperto()
    {
        SceneManager.LoadScene("MultiLocalExperto");
    }

    public void Regresar()
    {
        //SceneManager.LoadScene("");                               //REGRESAR A LA ESCENA PASADA **MAIN MENU**
    }

}
