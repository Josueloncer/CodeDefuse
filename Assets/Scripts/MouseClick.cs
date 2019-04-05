using System.Collections;
using System.Collections.Generic;

public class MouseClick
{
    private  ResetMouseClick ResetiarClicks = new ResetMouseClick();
    public bool RevisarClicks(bool _click)
    {
        if (_click == true)
        {
            OnlinePlayersLogics.Tap_Del_Jugador += 1;
            OnlinePlayersLogics.Tiempo_De_Espera_Despues_Del_Tap = .5f;
            
            LogicaVer4.Tap_Del_Jugador += 1;
            LogicaVer4.Tiempo_De_Espera_Despues_Del_Tap = .5f;
            ResetiarClicks.TapDelJugador(LogicaJ1.Tap_Del_Jugador_1, 7);
            return true;
        }
        else
        {
            return false;
        }
    }
}
