using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestablecerStatic : MonoBehaviour {
    
	void Start ()
    {
        LogicaVer4.Numero_De_Focos_Prendidos = 0;
        LogicaVer4.Jugando = true;

        LogicaJ1.Numero_De_Focos_Prendidos = 0;
        LogicaJ1.Jugando = true;
        LogicaJ1.TiempoDeEsperaParaRegrezarAMenu = 0;
        LogicaJ1.J1Gano = 0;

        LogicaJ2.Numero_De_Focos_Prendidos = 0;
        LogicaJ2.Jugando = true;
        LogicaJ2.TiempoDeEsperaParaRegrezarAMenu = 0;
        LogicaJ2.J2Gano = 0;

    }
}
