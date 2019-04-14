using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class CambiarEscena : MonoBehaviour {

    public void Cambiar_Escena(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }
    public void IrAMenu(string Escena)
    {
        NetworkManager.singleton.StopHost();
        SceneManager.LoadScene("00Main_Menu");
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
