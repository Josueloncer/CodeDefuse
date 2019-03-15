using System.Collections;
using System.Collections.Generic;

public class CondicionVictoriaJ1{

    public bool condiciondevictoria(int FocosPrendidos, int FocosParaGanar)
    {
        if (FocosPrendidos == FocosParaGanar)
        {
            LogicaJ1.Jugando = false;//////////////////////////////////////// CAMBIAR
            LogicaJ2.Jugando = false;//////////////////////////////////////// CAMBIAR
            LogicaJ1.J1Gano = 1;
            return true;
        }

        else
        {
            return false;
        }
    }
}
