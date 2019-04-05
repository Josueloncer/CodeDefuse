using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnlinePlayersLogics : MonoBehaviour{
  	public static int Numero_De_Focos_Prendidos;
    public static bool Jugando = true, winUP = false;

    public static float Tiempo_De_Espera_Despues_Del_Tap = 1f;
    public static int Tap_Del_Jugador = 0;
    public static float Tapo = 0;
    public int Tap_Final;
    public float DeltaTime = 60;
    public static int valorMin = 1;
    public static int valorMax = 6;

    public static bool Gano;

    public GameObject[] Leds;

    [Header("Textos")]
    public Text TxtTiempo;
    public Text TxtTaps;

    public  List<int> ListaNumeros = new List<int>();
    private Revision revision = new Revision();
    private Tiempo tiempo = new Tiempo();
    private RevisarEscenaOnline revisar = new RevisarEscenaOnline();
    private CondicionVictoria Victoria = new CondicionVictoria();
    private CondicionDerrota Derrota = new CondicionDerrota();
    private CondicionVictoria victoriaEngin = new CondicionVictoria();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private Revision condicion = new Revision();
    private Tiempo tiempoEngine = new Tiempo();
    private RevisarEscenaOnline revisarEngine = new RevisarEscenaOnline();
    private MouseClick ClicksDeMouse = new MouseClick();
    private OnlineFather oFath = new OnlineFather();
    private Interface_Behaviours I_b = new Interface_Behaviours();
    
    
    private void Awake()
    {
    	
        Scene EscenaActual = SceneManager.GetActiveScene();
        int NumeroEscenaActual = EscenaActual.buildIndex;
        revisarEngine.RegresarNumeroDeFocos(NumeroEscenaActual);
        //OnlineFather.ListaNumeroz.ForEach(c => ListaNumeros.Add(c));
    }

    void Start()
    {
    	FillObjectsz();
        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscenaOnline.FocosParaNivel);     //ELIMINR EL +1 CUANDO ACOMODEN LAS ESCENAS
        //ListaNumeros = new List<int>(OnlineFather.ListaNumeroz);
        //clientes.ForEach(c => clientes2.Add(c));
    }

    

    void Update()
    {
    	if(Tapo == 1) Tap_Del_Jugador+=1;

            if (Tiempo_De_Espera_Despues_Del_Tap >= 0 && DeltaTime > 0)
            {
                Tiempo_De_Espera_Despues_Del_Tap -= Time.deltaTime * 1;
                if (Tiempo_De_Espera_Despues_Del_Tap <= 0)
                {
                    Tap_Final = Tap_Del_Jugador;
                    Tap_Del_Jugador = 0;
                    Tapo = 0;
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
                if(victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscenaOnline.FocosParaNivel) == true)
                    {
                        //SceneManager.LoadScene("02Menu");
                        winUP = true;
                        DeltaTime = 60;
                        Numero_De_Focos_Prendidos = 0;
                        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscenaOnline.FocosParaNivel);     //ELIMINR EL +1 CUANDO ACOMODEN LAS ESCENAS
                        //oFath.RestartGame();
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

    void FillObjectsz(){
    	for(int v = 0; v < Leds.Length; v++){
    		Leds[v] = GameObject.Find("foco"+(v+1).ToString());
    	}
    	TxtTiempo = GameObject.Find("TextTiempo").GetComponent<Text>();
    	TxtTaps = GameObject.Find("TextTap").GetComponent<Text>();
    }
}
