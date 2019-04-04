using System.Collections;
using System.Collections.Generic;

public class ResetMouseClickJ2
{
    public bool TapDelJugador(int Taps, int TapsMaximo)
    {
        if (Taps >= TapsMaximo)
        {
            LogicaJ2.Tap_Del_Jugador_2 = 1;
            return true;
        }
        else
        {
            return false;
        }
    }
}
