using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroyOnload : MonoBehaviour {
	
	public static float BestSinEas = 60, BestSinNor = 60, BestSinHar = 60, BestSinExt = 60;

	bool Awake(){
			if(transform.gameObject != null)
			{
				DontDestroyOnLoad (transform.gameObject);
				return true;	
			}else{return false;}
	}
//1 = para la musica. 2 = no hagas nada ya esta reproduciendose. 3 = Reproduce la musica. 4 = no hagas nada;
	int OnLevelWasLoaded(int level){

        if(level >= 8 && level <=15 || level >= 17 && level <= 20)
        {
			GameObject.Find("MenuMusicPlayer").GetComponent<AudioSource>().Stop();
			return 1;
		}
		if(level == 1)
        {
			if(GameObject.Find("MenuMusicPlayer").GetComponent<AudioSource>().isPlaying){
				return 2;
				}else{GameObject.Find("MenuMusicPlayer").GetComponent<AudioSource>().Play(); return 3;}
		}
		return 4;
	}

}
