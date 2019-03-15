using System.Collections;
using System.Collections.Generic;

public class CondicionVictoriaJ2{

    public bool condiciondevictoria(int FocosPrendidos, int FocosParaGanar)
    {
        if (FocosPrendidos == FocosParaGanar)
        {
            LogicaJ1.Jugando = false;//////////////////////////////////////// CAMBIAR
            LogicaJ2.Jugando = false;//////////////////////////////////////// CAMBIAR
            LogicaJ2.J2Gano = 2;
            return true;
        }

        else
        {
            return false;
        }
    }
}
