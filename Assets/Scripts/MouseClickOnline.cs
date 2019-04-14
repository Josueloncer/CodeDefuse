using System.Collections;
using System.Collections.Generic;using UnityEngine.Networking;

public class MouseClickOnline
{
    private  ResetMouseClickOnline ResetiarClicks = new ResetMouseClickOnline();
    public bool RevisarClicks(bool _click)
    {
        if (_click == true)
        {
            LogicaOnline.Tap_Del_Jugador += 1;
            LogicaOnline.Tiempo_De_Espera_Despues_Del_Tap = .5f;
            ResetiarClicks.TapDelJugador(LogicaOnline.Tap_Del_Jugador, 6);
            return true;
        }

        return false;
    }
}
