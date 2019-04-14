using System.Collections;
using System.Collections.Generic;

public class ResetMouseClick
{
    public bool TapDelJugador(int Taps, int MaxTaps)
    {
        if (Taps >= MaxTaps)
        {
            LogicaVer4.Tap_Del_Jugador = 1;
        }
        return true;
    }
}
