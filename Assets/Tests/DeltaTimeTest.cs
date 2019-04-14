using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class DeltaTimeTest {

    [Test]
    public void DeltaTimeTestSimplePasses() {
        var engine = new DeltaTime();

        float TiempoDeJuego = 60.0f;
        float DeltaTime = 0.0001234f;

        var result = engine.restarTiempo(TiempoDeJuego, DeltaTime);

        Assert.Less(result,TiempoDeJuego);
    }
}
