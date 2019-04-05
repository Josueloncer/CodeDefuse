using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevisarEscenaOnline
{
    public static int FocosParaNivel;

    public int RegresarNumeroDeFocos(int EscnaActual)
    {
        switch (EscnaActual)
        {
            case 16:
                FocosParaNivel = 4;
                break;
            case 9:
                FocosParaNivel = 6;
                break;
            case 10:
                FocosParaNivel = 8;
                break;
            case 11:
                FocosParaNivel = 10;
                break;


            case 12:
                FocosParaNivel = 4;
                break;
            case 13:
                FocosParaNivel = 6;
                break;
            case 14:
                FocosParaNivel = 8;
                break;
            case 15:
                FocosParaNivel = 10;
                break;
        }

        return FocosParaNivel;
    }

    
}

