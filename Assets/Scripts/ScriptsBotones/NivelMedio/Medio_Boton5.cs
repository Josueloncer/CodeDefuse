﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medio_Boton5 : MonoBehaviour {
    public Sprite sprite1;
    public Sprite sprite2;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CambiarColor();
    }

    public void CambiarColor()
    {
        if (TapMedio.numeroRandomBool5 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = sprite2;
        }
    }
}
