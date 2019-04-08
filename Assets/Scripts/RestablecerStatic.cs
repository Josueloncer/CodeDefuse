using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestablecerStatic: MonoBehaviour
{
    public void Awake()
    {
        LogicaVer4.Numero_De_Focos_Prendidos = 0;
        LogicaVer4.Jugando = true;
        LogicaVer4.Tiempo_De_Espera_Despues_Del_Tap = 1f;
        LogicaVer4.Tap_Del_Jugador = 0;

        LogicaJ1.Numero_De_Focos_Prendidos = 0;
        LogicaJ1.Jugando = true;
        LogicaJ1.TiempoDeEsperaParaRegrezarAMenu = 0;
        LogicaJ1.Tiempo_De_Espera_Despues_Del_Tap_1 = 1f;
        LogicaJ1.Tap_Del_Jugador_1 = 0;
        LogicaJ1.J1Gano = 0;

        LogicaJ2.Numero_De_Focos_Prendidos = 0;
        LogicaJ2.Jugando = true;
        LogicaJ2.TiempoDeEsperaParaRegrezarAMenu = 0;
        LogicaJ2.Tiempo_De_Espera_Despues_Del_Tap_2 = 1f;
        LogicaJ2.Tap_Del_Jugador_2 = 0;
        LogicaJ2.J2Gano = 0;
    }
}
