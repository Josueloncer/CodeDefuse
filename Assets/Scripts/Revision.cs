public class Revision
{
	public bool RevisionResultado(int TapFinal, int NumeroLista)
	{
		if (TapFinal == NumeroLista)
		{
			LogicaVer4.Numero_De_Focos_Prendidos++;
			return true;
		}

		LogicaVer4.Numero_De_Focos_Prendidos = 0;
		return false;
	}
}