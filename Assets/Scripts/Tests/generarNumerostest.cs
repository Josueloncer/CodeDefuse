using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class generarNumerostest {


    [Test]
    public void generarNumeros()
    {
        int valorMin;
        int valorMax;
        int numeroAleatorio;

        numeroAleatorio = Random.Range(1, 6);

        Assert.AreEqual(numeroAleatorio,1,2);
    }

}
