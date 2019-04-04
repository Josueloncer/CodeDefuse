using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class RevisarEscenaTest
{
    
    [Test]
    public void RevisarEscenaFacil()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 4;
        int _EscenaActual = 8;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(4, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaNormal()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 6;
        int _EscenaActual = 9;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(6, _FocosParaNivel);

    }
    
    [Test]
    public void RevisarEscenaDificil()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 8;
        int _EscenaActual = 10;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(8, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaExtremo()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 10;
        int _EscenaActual = 11;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(10, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaFacilMJ()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 4;
        int _EscenaActual = 12;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(4, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaNormalMJ()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 6;
        int _EscenaActual = 13;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(6, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaDificilMJ()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 8;
        int _EscenaActual = 14;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(8, _FocosParaNivel);

    }

    [Test]
    public void RevisarEscenaExtremoMJ()
    {

        var engine = new RevisarEscena();

        int _FocosParaNivel = 10;
        int _EscenaActual = 15;

        var resutado = engine.RegresarNumeroDeFocos(_EscenaActual);

        Assert.AreEqual(10, _FocosParaNivel);
        
    }
}
