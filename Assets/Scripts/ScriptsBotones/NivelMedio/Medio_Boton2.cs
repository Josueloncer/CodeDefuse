﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medio_Boton2 : MonoBehaviour {

    public Sprite sprite1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CambiarColor();
    }

    void CambiarColor()
    {
        if (TapMedio.numeroRandomBool2 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
    }
}