using System.Collections;
using System.Collections.Generic;

public class ResetMouseClickJ1
{
    public bool TapDelJugador(int Taps, int TapsMaximo)
    {
        if (Taps >= TapsMaximo)
        {
            LogicaJ1.Tap_Del_Jugador_1 = 1;
            return true;
        }
        else
        {
            return false;
        }
    }
}
