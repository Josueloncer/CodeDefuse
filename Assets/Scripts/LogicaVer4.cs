using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaVer4 : MonoBehaviour
{
    public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true;

    public float Tiempo_De_Espera_Despues_Del_Tap = 1f;
    public int Tap_Del_Jugador = 0;
    public int Tap_Final;
    public float DeltaTime;
    public int valorMin = 1;
    public int valorMax = 6;

    public GameObject[] Leds;

    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;
    
    public List<int> ListaNumeros = new List<int>();
    private CondicionVictoria victoriaEngin = new CondicionVictoria();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private Revision condicion = new Revision();

    void Start()
    {
        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscena.FocosParaNivel);     //ELIMINR EL +1 CUANDO ACOMODEN LAS ESCENAS
    }

    void Update()
    {
            if (Tiempo_De_Espera_Despues_Del_Tap >= 0 && DeltaTime > 0)
            {
                Tiempo_De_Espera_Despues_Del_Tap -= Time.deltaTime * 1;
                if (Tiempo_De_Espera_Despues_Del_Tap <= 0)
                {
                    Tap_Final = Tap_Del_Jugador;
                    Tap_Del_Jugador = 0;
                    condicion.RevisionResultado(Tap_Final, ListaNumeros[Numero_De_Focos_Prendidos]);
                    PrenderLed(Numero_De_Focos_Prendidos);
                }
            }

            if (Jugando && DeltaTime > 0)
            {
                MouseClik();
                DeltaTime -= Time.deltaTime * 1;
                if(victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel))
                    {
                        SceneManager.LoadScene("02Menu");
                    }
                if (derrotaEngine.RevisarTiempo(DeltaTime))
                {
                    SceneManager.LoadScene("02Menu");
                }
            TxtTiempo.text = DeltaTime.ToString("F0");
            }

            TxtTaps.text = Tap_Del_Jugador.ToString();
    }

    void MouseClik()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Tap_Del_Jugador += 1;
            Tiempo_De_Espera_Despues_Del_Tap = .5f;
            if (Tap_Del_Jugador >= 7)
            {
                Tap_Del_Jugador = 1;
            }
        }
    }

    public void PrenderLed(int Numero_De_Focos_Prendidos)
    {
		if(Numero_De_Focos_Prendidos == 0)
		{
			for (int i = 0; i < Leds.Length; i++)
			{
				Leds[i].SetActive(true);
			}

			return;
		}

		Leds[Numero_De_Focos_Prendidos-1].SetActive(false);
    }
}