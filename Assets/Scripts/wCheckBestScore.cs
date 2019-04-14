using System.Collections;
using System.Collections.Generic;

public class wCheckBestScore
{
	public float SetHighScore(float ActualScore, float NewScore)
	{
		if(NewScore < ActualScore)
		{
			return NewScore;
		}else{
			return ActualScore;
		}
	}

	public float ActualScoreSetter(float DeltaTime){
		DeltaTime = 60 - DeltaTime;
		return DeltaTime;
	}

}
