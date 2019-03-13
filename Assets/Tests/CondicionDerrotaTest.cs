using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CondicionDerrotaTest {
    
    [Test]
    public void CondicionDerrotaSimplePasses()
    {

        float tiempoActual = 5;

        var engin = new CondicionDerrota();

        var result = engin.RevisarTiempo(tiempoActual);

        Assert.IsFalse(result);

    }
    [Test]
    public void CondicionDerrotaSimplePasses2()
    {

        float tiempoActual = 0;

        var engin = new CondicionDerrota();

        var result = engin.RevisarTiempo(tiempoActual);

        Assert.IsTrue(result);

    }
}
