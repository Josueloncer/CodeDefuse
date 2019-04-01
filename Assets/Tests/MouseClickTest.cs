using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MouseClickTest {

    [Test]
    public void MouseClickTestSimplePasses()
    {
        var engine = new MouseClick();

        bool _click = true;

        var resultado = engine.RevisarClicks(_click);

        Assert.AreEqual(_click, true);
    }

    [Test]
    public void MouseClickTestSimplePasses2()
    {
        var engine = new MouseClick();

        bool _click = false;

        var resultado = engine.RevisarClicks(_click);

        Assert.AreEqual(_click, false);
    }


    [Test]
    public void MouseClickTestSimplePasses3()
    {
        var engine = new MouseClick();

        bool _click = false;
        int num = 7;

        var resultado = engine.RevisarClicks(_click);

        var res = engine.RevisarClicks(_click);



        Assert.AreEqual(_click, false);
    }
}

