using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour {

    public Text NumeroTap;
    public int contador;
    public float tiempo;
    public bool activar;

    public void Start()
    {
        NumeroRandom();
    }

    public void Tiempo()
    {
        tiempo += Time.deltaTime;

        if(tiempo>2)
        {
            contador = 0;
        }
    }

    public void TapContador()
    {
        if (Input.GetMouseButtonDown(0))
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
        for(int i=0; i<5; i++)
        {
            int numeroRandom = Random.Range(1, 10);
            Debug.Log(numeroRandom);
        }
    }

    public void MostrarContador()
    {
        NumeroTap.text = contador.ToString();
    }

	// Update is called once per frame
	void Update ()
    {
        TapContador();
        MostrarContador();
    }
}
