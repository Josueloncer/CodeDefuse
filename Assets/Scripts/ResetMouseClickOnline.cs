using System.Collections;
using System.Collections.Generic;

public class ResetMouseClickOnline
{
    public bool TapDelJugador(int Taps, int MaxTaps)
    {
        if (Taps >= MaxTaps)
        {
            LogicaOnline.Tap_Del_Jugador = 1;
        }
        return true;
    }
}
