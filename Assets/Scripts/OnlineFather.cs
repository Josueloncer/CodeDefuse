using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlineFather : MonoBehaviour {

	public static List<int> ListaNumeroz = new List<int>();
	public GenerarNumeros engine = new GenerarNumeros();

	public int valorMin = 1;
    public int valorMax = 6;

	void Awake () {
		valorMin = OnlinePlayersLogics.valorMin;
		valorMax = OnlinePlayersLogics.valorMax;
		ListaNumeroz = engine.CreateRandomList(valorMin, valorMax, RevisarEscenaOnline.FocosParaNivel);
	}

	public void RestartGame(){
		ListaNumeroz = engine.CreateRandomList(valorMin, valorMax, RevisarEscenaOnline.FocosParaNivel);
	}

}
