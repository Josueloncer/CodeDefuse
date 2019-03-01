using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour {

    public float TiempoDeJeugo;
    public Text TxtTiempo;

    [Header("MUSICA")]
    public AudioClip Win;
    public AudioClip Loose;
    AudioSource musica;
    bool Jugando = true;

    private void Start()
    {
        musica = GetComponent<AudioSource>();
    }

    void Update ()
    {
        if(TiempoDeJeugo > 0 && Jugando == true)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
        {
            TiempoDeJeugo -= 1 * Time.deltaTime;        
        }

        if(Input.GetKeyDown("space"))                   //LO QUE SUCEDE CUANDO EL JUGADOR GANA
        {
            Jugando = false;
            Ganar();
        }

        if (TiempoDeJeugo <= 0 && Jugando == true)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
        {
            Jugando = false;
            
            Perder();
        }

        TxtTiempo.text = TiempoDeJeugo.ToString("F0");

	}

    public void Perder()                                   //LO QUE SUCEDE CUANDO PIERDES
    {
        musica.Stop();
        musica.clip = Loose;
        musica.loop = false;
        musica.Play();
        Debug.Log("ERES UN PERDEDOR");
    }

    public void Ganar()                                    //LO QUE SUCEDE CUANDO GANAS
    {
        Debug.Log("ERES UN GANADOR");
        musica.clip = Win;
        musica.loop = false;
        musica.Play();
    }
    

}
