using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class UT
{
    //
    bool numeroRandombool = false;
    bool numeroRandombool2 = false;
    bool numeroRandombool3 = false;
    bool numeroRandombool4 = false;

    [Test]
    public void CondicionVictoria1Facil()
    {
        int contador = 0;
        int numeroAleatorio = 0;

        contador = 3;
        numeroAleatorio = 3;

        if (contador == numeroAleatorio)
        {
            numeroRandombool = true;
        }

        Assert.IsTrue(numeroRandombool);
    }

    [Test]
    public void CondicionVictoria2Facil()
    {
        int contador = 0;
        int numeroAleatorio = 0;

        contador = 3;
        numeroAleatorio = 3;

        if (numeroRandombool == true)
        {
            if (contador == numeroAleatorio)
            {
                numeroRandombool2 = true;
            }
        }

        Assert.IsTrue(numeroRandombool2);
    }

    [Test]
    public void CondicionVictoria3Facil()
    {
        int contador = 0;
        int numeroAleatorio = 0;

        contador = 3;
        numeroAleatorio = 3;

        if (numeroRandombool2 == true)
        {
            if (contador == numeroAleatorio)
            {
                numeroRandombool3 = true;
            }
        }

        Assert.IsTrue(numeroRandombool3);
    }

    [Test]
    public void CondicionVictoria4Facil()
    {
        int contador = 0;
        int numeroAleatorio = 0;

        contador = 3;
        numeroAleatorio = 3;

        if (numeroRandombool3 == true)
        {
            if (contador == numeroAleatorio)
            {
                numeroRandombool4 = true;
            }
        }

        Assert.IsTrue(numeroRandombool4);
    }

    [Test]
    public void VerificarGanaste()
    {
        bool ganasteTexto = false;

        if(numeroRandombool4 == true)
        {
            ganasteTexto = true;
        }

        Assert.IsTrue(ganasteTexto);

    }


}

