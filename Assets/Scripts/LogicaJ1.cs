using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaJ1 : MonoBehaviour
{
    public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true;
   

    static public float Tiempo_De_Espera_Despues_Del_Tap_1 = 1f;
    static public int Tap_Del_Jugador_1 = 0;
    public int Tap_Final;
    public float DeltaTime;
    public int valorMin = 1;
    public int valorMax = 6;

    public float TimeNexScene = 4;

    public static float TiempoDeEsperaParaRegrezarAMenu;


    public GameObject TxtGanarJ1;
    public static int J1Gano = 0;

    public GameObject[] Leds;
    

    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;
    
    public List<int> ListaNumeros = new List<int>();
    private Tiempo tiempo = new Tiempo();
    private RevisarEscena revisar = new RevisarEscena();
    private CondicionDerrota Derrota = new CondicionDerrota();
    private CondicionVictoriaJ1 victoriaEngin = new CondicionVictoriaJ1();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private RevisionJ1 condicion = new RevisionJ1();
    private Tiempo tiempoEngine = new Tiempo();
    private RevisarEscena revisarEngine = new RevisarEscena();
    private QuienGano quienganoengine = new QuienGano();
    private MouseClickJ1 ClicksDeMouseJ1 = new MouseClickJ1();

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

        if (quienganoengine.Gano(J1Gano) == 1)
        {
            TxtGanarJ1.SetActive(true);
            TimeNexScene -= Time.deltaTime * 1;
        }
        if (TimeNexScene <= 0)
        {
            SceneManager.LoadScene("02Menu");
        }

        if (Tiempo_De_Espera_Despues_Del_Tap_1 >= 0 && DeltaTime > 0)
            {
                Tiempo_De_Espera_Despues_Del_Tap_1 -= Time.deltaTime * 1;
                if (Tiempo_De_Espera_Despues_Del_Tap_1 <= 0)
                {
                    Tap_Final = Tap_Del_Jugador_1;
                    Tap_Del_Jugador_1 = 0;
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
                derrotaEngine.RevisarTiempo(DeltaTime);
                TxtTiempo.text = DeltaTime.ToString("F0");
            }

            TxtTaps.text = Tap_Del_Jugador_1.ToString();

        

    }

    void MouseClik()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            ClicksDeMouseJ1.RevisarClicks(true);
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
