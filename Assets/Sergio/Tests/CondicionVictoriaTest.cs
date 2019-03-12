using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CondicionVictoriaTest {

    [Test]
    public void CondicionVictoriaTestSimplePasses()
    {
        int _FocosPrendidos = 5;
        int _FocosParaGanar = 5;

        var engine = new CondicionVictoria();

        bool result = engine.condiciondevictoria(_FocosPrendidos, _FocosParaGanar);

        Assert.IsTrue(result);


    }

    [Test]
    public void CondicionVictoriaTestSimplePasses2()
    {
        int _FocosPrendidos = 6;
        int _FocosParaGanar = 5;

        var engine = new CondicionVictoria();

        bool result = engine.condiciondevictoria(_FocosPrendidos, _FocosParaGanar);

        Assert.IsFalse(result);


    }
}
