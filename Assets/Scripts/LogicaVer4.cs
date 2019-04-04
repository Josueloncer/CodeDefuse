using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaVer4 : MonoBehaviour
{
    public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true;

    public static float Tiempo_De_Espera_Despues_Del_Tap = 1f;
    public static int Tap_Del_Jugador = 0;
    public int Tap_Final;
    public float DeltaTime;
    public int valorMin = 1;
    public int valorMax = 6;

    public static bool Gano;

    public GameObject TextoGanador;
    public GameObject TextoPerdedor;

    public GameObject Foco1;
    public GameObject Foco2;
    public GameObject Foco3;
    public GameObject Foco4;
    public GameObject Foco5;
    public GameObject Foco6;
    public GameObject Foco7;
    public GameObject Foco8;
    public GameObject Foco9;
    public GameObject Foco10;

    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;

    public List<int> ListaNumeros = new List<int>();
    private Revision revision = new Revision();
    private Tiempo tiempo = new Tiempo();
    private RevisarEscena revisar = new RevisarEscena();
    private CondicionVictoria Victoria = new CondicionVictoria();
    private CondicionDerrota Derrota = new CondicionDerrota();
    private CondicionVictoria victoriaEngin = new CondicionVictoria();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private Revision condicion = new Revision();
    private Tiempo tiempoEngine = new Tiempo();
    private RevisarEscena revisarEngine = new RevisarEscena();
    private MouseClick ClicksDeMouse = new MouseClick();
    
    private void Awake()
    {
        Scene EscenaActual = SceneManager.GetActiveScene();
        int NumeroEscenaActual = EscenaActual.buildIndex;
        revisarEngine.RegresarNumeroDeFocos(NumeroEscenaActual);
    }

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
                    condicion.RevisionResultado(Tap_Final, ListaNumeros[Numero_De_Focos_Prendidos], Numero_De_Focos_Prendidos);
                    PrenderLed(Numero_De_Focos_Prendidos);
                }
            }

            if (Jugando == true && DeltaTime > 0)
            {
                MouseClik();
                DeltaTime -= Time.deltaTime * 1;
                tiempoEngine.TiempoJuego(DeltaTime);
                //victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel);
                if(victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel) == true)
                    {
                        SceneManager.LoadScene("02Menu");
                    }
                //derrotaEngine.RevisarTiempo(DeltaTime);
                if (derrotaEngine.RevisarTiempo(DeltaTime) == true)
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
            ClicksDeMouse.RevisarClicks(true);
        }
    }


    public bool PrenderLed(int Numero_De_Focos_Prendidos)
    {
        switch (Numero_De_Focos_Prendidos)
        {
            case 0:
                Foco1.SetActive(true);
                Foco2.SetActive(true);
                Foco3.SetActive(true);
                Foco4.SetActive(true);
                Foco5.SetActive(true);
                Foco6.SetActive(true);
                Foco7.SetActive(true);
                Foco8.SetActive(true);
                Foco9.SetActive(true);
                Foco10.SetActive(true);
                return false;
                break;

            case 1:
                Foco1.SetActive(false);
                return true;
                break;

            case 2:
                Foco2.SetActive(false);
                return true;
                break;

            case 3:
                Foco3.SetActive(false);
                return true;
                break;

            case 4:
                Foco4.SetActive(false);
                return true;
                break;

            case 5:
                Foco5.SetActive(false);
                return true;
                break;

            case 6:
                Foco6.SetActive(false);
                return true;
                break;

            case 7:
                Foco7.SetActive(false);
                return true;
                break;

            case 8:
                Foco8.SetActive(false);
                return true;
                break;

            case 9:
                Foco9.SetActive(false);
                return true;
                break;

            case 10:
                Foco10.SetActive(false);
                return true;
                break;

        }
        return true;
    }

}
