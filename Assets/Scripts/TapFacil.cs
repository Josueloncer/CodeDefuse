using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFacil : MonoBehaviour
{

    public Text NumeroTap;
    public int contador;

    public GameObject ganasteText;

    public static bool numeroRandomBool = false;
    public static bool numeroRandomBool2 = false;
    public static bool numeroRandomBool3 = false;
    public static bool numeroRandomBool4 = false;

    public int valorMin = 1;
    public int valorMax = 6;

    [Space(20)]
    public int valorSorteado;
    [Space(20)]
    public List<int> numeroJaSorteados = new List<int>();

    int numeroAleatorio;
    int numeroAleatorio2;
    int numeroAleatorio3;
    int numeroAleatorio4;

    bool ganaste = false;

    public void Start()
    {
        StartCoroutine(Contador());
        //numeroRandom = Random.Range(1, 6);
        //numeroRandom2 = Random.Range(1, 6);
        //numeroRandom3 = Random.Range(1, 6);
        //numeroRandom4 = Random.Range(1, 6);
        valorSorteado = GenerarNumeros();
        valorSorteado = GenerarNumeros2();
        valorSorteado = GenerarNumeros3();
        valorSorteado = GenerarNumeros4();
        Debug.Log(numeroAleatorio);
        Debug.Log(numeroAleatorio2);
        Debug.Log(numeroAleatorio3);
        Debug.Log(numeroAleatorio4);

    }

    public int GenerarNumeros()
    {
        if (Mathf.Abs(valorMax - valorMin) > numeroJaSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio = Random.Range(1, 6);
                if (numeroJaSorteados.Contains(numeroAleatorio)==false)
                {
                    numeroJaSorteados.Add(numeroAleatorio);
                    return numeroAleatorio;
                }
            }
        }
        else
        {
            Debug.LogError("Todos los numeros fueron sorteados");
            return 0;
        }
    }

    public int GenerarNumeros2()
    {
        if (Mathf.Abs(valorMax - valorMin) > numeroJaSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio2 = Random.Range(valorMin, valorMax);
                if (numeroJaSorteados.Contains(numeroAleatorio3)==false)
                {
                    numeroJaSorteados.Add(numeroAleatorio2
);
                    return numeroAleatorio2;
                }
            }
        }
        else
        {
            Debug.LogError("Todos los numeros fueron sorteados");
            return 0;
        }
    }

    public int GenerarNumeros3()
    {
        if (Mathf.Abs(valorMax - valorMin) > numeroJaSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio3 = Random.Range(valorMin, valorMax);
                if (numeroJaSorteados.Contains(numeroAleatorio3)==false)
                {
                    numeroJaSorteados.Add(numeroAleatorio3);
                    return numeroAleatorio3;
                }
            }
        }
        else
        {
            Debug.LogError("Todos los numeros fueron sorteados");
            return 0;
        }
    }

    public int GenerarNumeros4()
    {
        if (Mathf.Abs(valorMax - valorMin) > numeroJaSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio4 = Random.Range(valorMin, valorMax);
                if (numeroJaSorteados.Contains(numeroAleatorio4)==false)
                {
                    numeroJaSorteados.Add(numeroAleatorio4);
                    return numeroAleatorio4;
                }
            }
        }
        else
        {
            Debug.LogError("Todos los numeros fueron sorteados");
            return 0;
        }
    }

    public void TapContador()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contador = contador + 1;
        }
    }

    IEnumerator Contador()
    {
        while (true)
        {
            TapContador();
            yield return new WaitForSeconds(3);
            contador = 0;
        }

    }

    public void CondicionVictoria()
    {
        if (contador == numeroAleatorio)
        {
            numeroRandomBool = true;
            Debug.Log(numeroRandomBool);
        }


        if (numeroRandomBool == true)
        {
           if(contador == numeroAleatorio2)
           {
                numeroRandomBool2 = true;
            }
        }

        if (numeroRandomBool2 == true)
        {
            if(contador==numeroAleatorio3)
            {
              numeroRandomBool3 = true;
            }
        }

        if (numeroRandomBool3 == true)
        {
            if(contador == numeroAleatorio4)
            {
                numeroRandomBool4 = true;

                ganasteText.SetActive(true);
            }

        }
    }
    

    public void MostrarContador()
    {
        NumeroTap.text = contador.ToString();
    }

	void Update ()
    {
        TapContador();
        MostrarContador();
        CondicionVictoria();
    }
}

