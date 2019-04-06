using System.Collections;
using System.Collections.Generic;

public class MouseClickJ2
{
    private  ResetMouseClickJ2 ResetiarClicks = new ResetMouseClickJ2();
    public bool RevisarClicks(bool _click)
    {
        if (_click == true)
        {
            LogicaJ2.Tap_Del_Jugador_2 += 1;
            LogicaJ2.Tiempo_De_Espera_Despues_Del_Tap_2 = .5f;
            ResetiarClicks.TapDelJugador(LogicaJ2.Tap_Del_Jugador_2, 6);
            return true;
        }
        else
        {
            return false;
        }
    }
}
