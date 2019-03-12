using System.Collections;
using System.Collections.Generic;

public class RevisarEscena
{
    public static int FocosParaNivel;

    public int RegresarNumeroDeFocos(int EscnaActual)
    {
        switch (EscnaActual)
        {
            case 1:
                FocosParaNivel = 4;
                break;
            case 2:
                FocosParaNivel = 6;
                break;
            case 3:
                FocosParaNivel = 8;
                break;
            case 4:
                FocosParaNivel = 10;
                break;


            case 5:
                FocosParaNivel = 4;
                break;
            case 6:
                FocosParaNivel = 6;
                break;
            case 7:
                FocosParaNivel = 8;
                break;
            case 8:
                FocosParaNivel = 10;
                break;
        }

        return FocosParaNivel;
    }

    
}
