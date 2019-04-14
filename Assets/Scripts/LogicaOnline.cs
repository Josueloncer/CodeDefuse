using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LogicaOnline : NetworkBehaviour
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
    public GameObject IMG_Ganar;
    public GameObject IMG_Perder;
    [Header("Numeros Generados")]
    public List<int> ListaNumeros = new List<int>();
    #endregion

    #region Clases Declaracion de Clases que se van a usar
    private RevisionOnline condicion = new RevisionOnline();
    private Tiempo tiempo = new Tiempo();
    private CondicionVictoria victoriaEngin = new CondicionVictoria();
    private CondicionDerrota derrotaEngine = new CondicionDerrota();
    private GenerarNumeros engine = new GenerarNumeros();
    private Tiempo tiempoEngine = new Tiempo();
    private RevisarEscena revisarEngine = new RevisarEscena();
    private MouseClickOnline ClicksDeMouse = new MouseClickOnline();
    private DeltaTime _deltaTime = new DeltaTime();
    #endregion
    public GameObject[] clientes;
    private bool localWinner;

    [SyncVar (hook = "OnChangeGameOver")]
    public bool gameOver;

    void OnChangeGameOver(bool _gameOver)
    {
        gameOver=_gameOver; 
        Debug.LogWarning("GameOver: " + gameOver);
        if (clientes.Length==0)
        {
            Debug.LogWarning("Clientes");
            clientes = GameObject.FindGameObjectsWithTag("Cliente");
        }

        foreach (GameObject cliente in clientes)
        {
            cliente.GetComponent<LogicaOnline>().gameOver=true;
        }
    } 

    [Command]
    public void CmdChangeGameOver()
    {
        gameOver=true;        
        Debug.LogWarning("CmdChangeGameOver: " + gameOver);
    }

    private void Awake()
    {
        Scene EscenaActual = SceneManager.GetActiveScene();
        int NumeroEscenaActual = EscenaActual.buildIndex;
        revisarEngine.RegresarNumeroDeFocos(NumeroEscenaActual);
    }

    void Start()
    {    
        localWinner =false;
        if(isLocalPlayer)
        {
            GetComponent<LogicaOnline>().enabled = true;
            this.transform.gameObject.SetActive(true);
            this.transform.gameObject.tag= "Cliente";
        }else
        {
            GetComponent<LogicaOnline>().enabled = false;
            this.transform.gameObject.SetActive(false);
            this.transform.gameObject.tag= "Server";
        }
        ListaNumeros = engine.CreateRandomList(valorMin, valorMax, RevisarEscena.FocosParaNivel); 
    }

    void Update()
    {
        if(!gameOver)
        {
            if (Tiempo_De_Espera_Despues_Del_Tap >= 0 && DeltaTime > 0)
            {
                Tiempo_De_Espera_Despues_Del_Tap = _deltaTime.restarTiempo(Tiempo_De_Espera_Despues_Del_Tap, Time.deltaTime);
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
                DeltaTime = _deltaTime.restarTiempo(DeltaTime, Time.deltaTime);
                tiempoEngine.TiempoJuego(DeltaTime);

                if (victoriaEngin.condiciondevictoria(Numero_De_Focos_Prendidos, RevisarEscena.FocosParaNivel) == true)
                {
                    //IMG_Ganar.SetActive(true);
                    localWinner =true;
                    Jugando = false;
                    CmdChangeGameOver();
                }

                if (derrotaEngine.RevisarTiempo(DeltaTime) == true)
                {
                    //IMG_Perder.SetActive(true);
                    Jugando = false;
                    localWinner =false;
                    CmdChangeGameOver();
                }
                TxtTiempo.text = DeltaTime.ToString("F0");
            }

            TxtTaps.text = Tap_Del_Jugador.ToString();
        }else if(localWinner)
        {
            IMG_Ganar.SetActive(true);
        }else
        {
            IMG_Perder.SetActive(true);
        }
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