﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificil_Boton4 : MonoBehaviour {

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

    public void CambiarColor()
    {
        if (TapDificil.numeroRandomBool4 == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
    }
}
