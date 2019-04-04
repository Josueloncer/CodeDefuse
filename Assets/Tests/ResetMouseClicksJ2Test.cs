using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ResetMouseClicksJ2Test {

    [Test]
    public void ResetClicksTestSimplePasses()
    {
        int Taps = 5;
        int MaxTaps = 7;

        var engine = new ResetMouseClickJ2();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsFalse(result);
    }

    [Test]
    public void ResetClicksTestSimplePasses2()
    {
        int Taps = 8;
        int MaxTaps = 7;

        var engine = new ResetMouseClickJ2();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsTrue(result);
    }

}
