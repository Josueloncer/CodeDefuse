using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador1Normal : MonoBehaviour {

    public Text NumeroTap;
    public int contador;
    public float tiempo;
    public bool activar;

    int numeroRandom;
    int numeroRandom2;
    int numeroRandom3;
    int numeroRandom4;
    int numeroRandom5;
    int numeroRandom6;



    bool numeroRandomBool = false;
    //bool numeroRandomBool2 = false;
    //bool numeroRandomBool3 = false;
    //bool numeroRandomBool4 = false;

    bool ganaste = false;

    public void Start()
    {

        numeroRandom = Random.Range(1, 6);
        numeroRandom2 = Random.Range(1, 6);
        numeroRandom3 = Random.Range(1, 6);
        numeroRandom4 = Random.Range(1, 6);
        numeroRandom5 = Random.Range(1, 6);
        numeroRandom6 = Random.Range(1, 6);
        NumeroRandom();


    }

    public void Tiempo()
    {
        tiempo += Time.deltaTime;

        if(tiempo>2)
        {
            contador = 0;
            tiempo = 0;
        }
    }

    public void TapContador()
    {
        if (Input.GetKeyUp("left shift") == true)
        {
            contador = contador + 1;
            activar = true;
            tiempo = 0;
        }

        if(activar == true)
        {
            Tiempo();
        }
    }


    public void NumeroRandom()
    {
        /*for(int i=0; i<5; i++)
        {
            int numeroRandom = Random.Range(1, 10);
            Debug.Log(numeroRandom);
        }
        */
        Debug.Log(numeroRandom);
        Debug.Log(numeroRandom2);
        Debug.Log(numeroRandom3);
        Debug.Log(numeroRandom4);
        Debug.Log(numeroRandom5);
        Debug.Log(numeroRandom6);

        if (ganaste == true)
        {
            Debug.Log("Ganaste");
        }
    }

    public void CondicionVictoria()
    {
        if (contador == numeroRandom)
        {
            numeroRandomBool = true;
            Debug.Log(numeroRandomBool);
            /*if (contador == numeroRandom2)
            {
                numeroRandomBool2 = true;
                if (contador == numeroRandom3)
                {
                    numeroRandomBool3 = true;
                    if (contador == numeroRandom4)
                    {
                        numeroRandomBool4 = true;
                        ganaste = true;
                    }
                }
            }
            */
        }
    }

    public void MostrarContador()
    {
        NumeroTap.text = contador.ToString();
    }

    void Update ()
    {
        TapContador();
        MostrarContador();
        CondicionVictoria();
    }
}
