using System.Collections;
using System.Collections.Generic;

public class CondicionVictoria{

    public bool condiciondevictoria(int FocosPrendidos, int FocosParaGanar)
    {
        if (FocosPrendidos == FocosParaGanar)
        {
            LogicaVer4.Jugando = false;//////////////////////////////////////// CAMBIAR
            OnlinePlayersLogics.Jugando = false;
            return true;
        }

        else
        {
            return false;
        }
    }
}
