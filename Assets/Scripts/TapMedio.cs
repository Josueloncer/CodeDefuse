using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapMedio : MonoBehaviour {

    int numeroAleatorio;
    int numeroAleatorio2;
    int numeroAleatorio3;
    int numeroAleatorio4;
    int numeroAleatorio5;
    int numeroAleatorio6;

    public int valorMin = 1;
    public int valorMax = 6;

    public Text ganaste;

    public Text NumeroTap;
    public int contador;

    [Space(20)]
    public int valorSorteado;
    [Space(20)]
    public List<int> numerosSorteados = new List<int>();

    public static bool numeroRandomBool = false;
    public static bool numeroRandomBool2 = false;
    public static bool numeroRandomBool3 = false;
    public static bool numeroRandomBool4 = false;
    public static bool numeroRandomBool5 = false;
    public static bool numeroRandomBool6 = false;

    public GameObject ganasteText;

    public void Start()
    {
        StartCoroutine(Contador());

        valorSorteado = GenerarNumeros();
        valorSorteado = GenerarNumeros2();
        valorSorteado = GenerarNumeros3();
        valorSorteado = GenerarNumeros4();
        valorSorteado = GenerarNumeros5();
        valorSorteado = GenerarNumeros6();
        Debug.Log(numeroAleatorio);
        Debug.Log(numeroAleatorio2);
        Debug.Log(numeroAleatorio3);
        Debug.Log(numeroAleatorio4);
        Debug.Log(numeroAleatorio5);
        Debug.Log(numeroAleatorio6);

    }

    public int GenerarNumeros()
    {
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio = Random.Range(1, 6);
                if (numerosSorteados.Contains(numeroAleatorio) == false)
                {
                    numerosSorteados.Add(numeroAleatorio);
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
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio2 = Random.Range(valorMin, valorMax);
                if (numerosSorteados.Contains(numeroAleatorio3) == false)
                {
                    numerosSorteados.Add(numeroAleatorio2);
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
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio3 = Random.Range(valorMin, valorMax);
                if (numerosSorteados.Contains(numeroAleatorio3) == false)
                {
                    numerosSorteados.Add(numeroAleatorio3);
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
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio4 = Random.Range(valorMin, valorMax);
                if (numerosSorteados.Contains(numeroAleatorio4) == false)
                {
                    numerosSorteados.Add(numeroAleatorio4);
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

    public int GenerarNumeros5()
    {
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio5 = Random.Range(valorMin, valorMax);
                if (numerosSorteados.Contains(numeroAleatorio5) == false)
                {
                    numerosSorteados.Add(numeroAleatorio5);
                    return numeroAleatorio5;
                }
            }
        }
        else
        {
            Debug.LogError("Todos los numeros fueron sorteados");
            return 0;
        }
    }

    public int GenerarNumeros6()
    {
        if (Mathf.Abs(valorMax - valorMin) > numerosSorteados.Count)
        {
            while (true)
            {
                numeroAleatorio6 = Random.Range(valorMin, valorMax);
                if (numerosSorteados.Contains(numeroAleatorio6) == false)
                {
                    numerosSorteados.Add(numeroAleatorio6);
                    return numeroAleatorio6;
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
            if (contador == numeroAleatorio2)
            {
                numeroRandomBool2 = true;
            }
        }

        if (numeroRandomBool2 == true)
        {
            if (contador == numeroAleatorio3)
            {
                numeroRandomBool3 = true;
            }
        }
        if (numeroRandomBool3 == true)
        {
            if (contador == numeroAleatorio4)
            {
                numeroRandomBool4 = true;
            }
        }

        if (numeroRandomBool4 == true)
        {
            if (contador == numeroAleatorio5)
            {
                numeroRandomBool5 = true;
            }
        }

        if (numeroRandomBool5 == true)
        {
            if (contador == numeroAleatorio6)
            {
                numeroRandomBool6 = true;
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
