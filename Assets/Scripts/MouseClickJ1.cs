using System.Collections;
using System.Collections.Generic;

public class MouseClickJ1
{
    private  ResetMouseClickJ1 ResetiarClicks = new ResetMouseClickJ1();
    public bool RevisarClicks(bool _click)
    {
        if (_click == true)
        {
            LogicaJ1.Tap_Del_Jugador_1 += 1;
            LogicaJ1.Tiempo_De_Espera_Despues_Del_Tap_1 = .5f;
            ResetiarClicks.TapDelJugador(LogicaJ1.Tap_Del_Jugador_1, 6);
            return true;
        }
        else
        {
            return false;
        }
    }
}
