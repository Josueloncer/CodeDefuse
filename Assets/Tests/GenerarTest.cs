using NUnit.Framework;

public class GenerarNumeroTest {
    [Test]
    public void GenerarNumerosUT()
    {
        //Arrange
        var engine = new GenerarNumeros();
        //Act
        var result = engine.CreateRandomList(1, 7, 5);
        //Assert
        Assert.IsNotNull(result);

        Assert.AreEqual(5, result.Count);

        for(int i =0; i<result.Count; i++)
        {
            Assert.IsTrue(result[i] >= 1 && result[i] < 7);
        }
    }
}
