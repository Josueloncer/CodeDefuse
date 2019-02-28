using NUnit.Framework;

namespace Tests
{
	public class TapFacilTests
    {
	    [Test]
	    public void TapFacilEngine_CreateRandomList_GeneratesListSuccessfully()
	    {
			// Arrange
			var engine = new TapFacilEngine();

			// Act
			var result = engine.CreateRandomList(1, 7, 6);

			// Assert
			Assert.IsNotNull(result); // Verificar que no sea nulo
			
			// TODO Verificar que no se repiten
			
			// Verificar que se generaron 6
			Assert.AreEqual(6, result.Count);

			// Verificar que los números están dentro del rango definido.
			for (int i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(result[i] >= 1 && result[i] < 7);
			}
	    }
    }
}