using System.Collections.Generic;

public class TapFacilEngine
{
	private static System.Random rnd = new System.Random();

	/// <summary>
	/// Genera una lista de números aleatorios que no se repitan, en un rango determinado.
	/// </summary>
	/// <param name="min">Valor mínimo para generar (inclusivo).</param>
	/// <param name="max">Valor máximo para generar (exclusivo).</param>
	/// <param name="count">Cantidad de números a generar.</param>
	/// <returns></returns>
	public List<int> CreateRandomList(int min, int max, int count)
	{
		var result = new List<int>();

		for (var i = 0; i < count; i++)
		{
			int num;
			do
			{
				num = rnd.Next(min, max);
			} while (result.Contains(num));
			result.Add(num);
		}

		return result;
	}
}