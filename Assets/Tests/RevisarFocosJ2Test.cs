using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class RevisarFocosJ2Test {

     [Test]
    public void RevisionFocosTestSimplePasses1()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 0;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal+1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses2()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 1;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses3()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 2;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses4()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 3;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses5()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 4;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses6()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 5;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses7()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 6;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }
    [Test]
    public void RevisionFocosTestSimplePasses8()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 7;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses9()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 8;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosTestSimplePasses10()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 9;

        var engine = new RevisionJ2();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }
}
