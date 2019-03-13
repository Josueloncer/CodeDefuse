using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TiempoTest {

    [Test]
    public void TiempoUT()
    {
        var engine = new Tiempo();
        
        float _tiempoRestante_ = 1;

        var result = engine.TiempoJuego(_tiempoRestante_);

        Assert.AreEqual(0.0f, result);


    }
}
