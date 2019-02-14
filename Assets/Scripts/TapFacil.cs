using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFacil : MonoBehaviour {

    public Text NumeroTap;
    public int contador;

    int numeroRandom;
    int numeroRandom2;
    int numeroRandom3;
    int numeroRandom4;

    public static bool numeroRandomBool = false;
    public static bool numeroRandomBool2 = false;
    public static bool numeroRandomBool3 = false;
    public static bool numeroRandomBool4 = false;

    bool ganaste = false;

    public void Start()
    {
        StartCoroutine(Contador());
        numeroRandom = Random.Range(1, 6);
        numeroRandom2 = Random.Range(1, 6);
        numeroRandom3 = Random.Range(1, 6);
        numeroRandom4 = Random.Range(1, 6);
        NumeroRandom();

    }

    public void TapContador()
    {
        if (Input.GetMouseButtonDown(0))
        {
                contador = contador + 1;
        }
    }

    IEnumerator Contador()
    {
        while(true)
        {
            TapContador();
            yield return new WaitForSeconds(3);
            contador = 0;
        }
        
    }

    public void NumeroRandom()
    {
        Debug.Log(numeroRandom);
        Debug.Log(numeroRandom2);
        Debug.Log(numeroRandom3);
        Debug.Log(numeroRandom4);

    }

    public void CondicionVictoria()
    {
        if (contador == numeroRandom)
        {
            numeroRandomBool = true;
            Debug.Log(numeroRandomBool);
        }

        if (numeroRandomBool == true)
        {
           if(contador == numeroRandom2)
           {
                numeroRandomBool2 = true;
            }
        }

        if (numeroRandomBool2 == true)
        {
            if(contador==numeroRandom3)
            {
              numeroRandomBool3 = true;
            }
        }

        if (numeroRandomBool3 == true)
        {
            if(contador == numeroRandom4)
            {
                numeroRandomBool4 = true;

                ganaste = true;
                if (ganaste == true)
                {
                    Debug.Log("Ganaste");
                }
            }

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
