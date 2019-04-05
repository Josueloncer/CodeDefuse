using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaJ2 : MonoBehaviour
{
    public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true;

    static public float Tiempo_De_Espera_Despues_Del_Tap_2 = 1f;
    static public int Tap_Del_Jugador_2 = 0;
    public int Tap_Final;
    public float DeltaTime;
    public int valorMin = 1;
    public int valorMax = 6;

    public float TimeNexScene = 4;



    public static float TiempoDeEsperaParaRegrezarAMenu;


    public GameObject TxtGanarJ2;
    public static int J2Gano = 0;

    public GameObject[] Leds;

    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;
    
    public List<int> ListaNumeros = new List<int>();
    private Tiempo tiempo = new Tiempo();
    private RevisarEscena revisar = new RevisarEscena();
    private CondicionDerrota Derrota = new CondicionDerrota();
    private CondicionVictoriaJ2 victoriaEngin = new CondicionVictoriaJ2();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private RevisionJ2 condicion = new RevisionJ2();
    private Tiempo tiempoEngine = new Tiempo();
    private RevisarEscena revisarEngine = new RevisarEscena();
    private QuienGano quienganoengine  = new QuienGano();
    private MouseClickJ2 ClicksDeMouseJ2 = new MouseClickJ2();

    private void Awake()
    {
        Scene EscenaActual = SceneManager.GetActiveScene();
        int NumeroEscenaActual = EscenaActual.buildIndex;
        revisarEngine.RegresarNumeroDeFocos(NumeroEscenaActual+1);
    }

    void Start()
    {
        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscena.FocosParaNivel);     //ELIMINR EL +1 CUANDO ACOMODEN LAS ESCENAS
        Debug.Log(RevisarEscena.FocosParaNivel);
    }

    void Update()
    {
        if (quienganoengine.Gano(J2Gano) == 2)
        {
            TxtGanarJ2.SetActive(true);
            TimeNexScene -= Time.deltaTime * 1;
        }

        if (TimeNexScene <= 0)
        {
            SceneManager.LoadScene("02Menu");
        }

        if (Tiempo_De_Espera_Despues_Del_Tap_2 >= 0 && DeltaTime > 0)
            {
                Tiempo_De_Espera_Despues_Del_Tap_2 -= Time.deltaTime * 1;
                if (Tiempo_De_Espera_Despues_Del_Tap_2 <= 0)
                {
                    Tap_Final = Tap_Del_Jugador_2;
                    Tap_Del_Jugador_2 = 0;
                    condicion.RevisionResultado(Tap_Final, ListaNumeros[Numero_De_Focos_Prendidos], Numero_De_Focos_Prendidos);
                    PrenderLed( Numero_De_Focos_Prendidos);
                }
            }

            if (Jugando == true && DeltaTime > 0)
            {
                MouseClik();
                DeltaTime -= Time.deltaTime * 1;
                tiempoEngine.TiempoJuego(DeltaTime);
                victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel);
                quienganoengine.Gano(0);// EL QUIEN GANO EL JUEGO    
                derrotaEngine.RevisarTiempo(DeltaTime);
                TxtTiempo.text = DeltaTime.ToString("F0");

            }

            TxtTaps.text = Tap_Del_Jugador_2.ToString();

            
            
    }

    void MouseClik()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            ClicksDeMouseJ2.RevisarClicks(true);
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
