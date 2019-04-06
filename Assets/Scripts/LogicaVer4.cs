using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaVer4 : MonoBehaviour
{
    #region Statics Lista de las variables Estaticas
    public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true;
    public static float Tiempo_De_Espera_Despues_Del_Tap = 1f;
    public static int Tap_Del_Jugador = 0;
    #endregion

    #region Public Lista de las variables Publicas
    public int Tap_Final;
    public float DeltaTime;//el tiempo de juego
    public int valorMin = 1;
    public int valorMax = 5;
    [Header("Leds para el juego")]
    public GameObject[] Leds;
    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;
    [Header("Numeros Generados")]
    public List<int> ListaNumeros = new List<int>();
    #endregion

    #region Clases Declaracion de Clases que se van a usar
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
    #endregion

    private void Awake()
    {
        Scene EscenaActual = SceneManager.GetActiveScene();
        int NumeroEscenaActual = EscenaActual.buildIndex;
        revisarEngine.RegresarNumeroDeFocos(NumeroEscenaActual);
    }

    void Start()
    {
        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscena.FocosParaNivel); 
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

            if (victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel) == true)
            {
                SceneManager.LoadScene("00Main_Menu");
            }

            if (derrotaEngine.RevisarTiempo(DeltaTime) == true)
            {
                SceneManager.LoadScene("00Main_Menu");
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
        if (Numero_De_Focos_Prendidos == 0)
        {
            for (int i = 0; i < Leds.Length; i++)
            {
                Leds[i].SetActive(true);
            }
            return false;
        }

        Leds[Numero_De_Focos_Prendidos - 1].SetActive(false);
        return true;
    }
}