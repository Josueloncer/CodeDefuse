using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ResetMouseClicksTest {

    [Test]
    public void ResetClicksTestSimplePasses2()
    {
        int Taps = 8;
        int MaxTaps = 7;

        var engine = new ResetMouseClick();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsTrue(result);
    }

}
