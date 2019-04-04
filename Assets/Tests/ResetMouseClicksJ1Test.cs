using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ResetMouseClicksJ1Test {

    [Test]
    public void ResetClicksTestSimplePasses()
    {
        int Taps = 5;
        int MaxTaps = 7;

        var engine = new ResetMouseClickJ1();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsFalse(result);
    }

    [Test]
    public void ResetClicksTestSimplePasses2()
    {
        int Taps = 8;
        int MaxTaps = 7;

        var engine = new ResetMouseClickJ1();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsTrue(result);
    }

}
