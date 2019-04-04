using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class QuienGanoTest {
    
    [Test]
    public void QuienGanoTestSimplePasses1()
    {

        var engine = new QuienGano();
        int _Ganador = 1;

        var resultado = engine.Gano(_Ganador);

        Assert.AreEqual(1, resultado);


    }

    [Test]
    public void QuienGanoTestSimplePasses2()
    {

        var engine = new QuienGano();
        int _Ganador = 2;

        var resultado = engine.Gano(_Ganador);

        Assert.AreEqual(2, resultado);

    }


    [Test]
    public void QuienGanoTestSimplePasses3()
    {

        var engine = new QuienGano();
        int _Ganador = 0;

        var resultado = engine.Gano(_Ganador);

        Assert.AreEqual(0, resultado);

    }
}
