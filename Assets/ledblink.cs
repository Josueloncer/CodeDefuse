using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino; 

public class ledblink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UduinoManager.Instance.pinMode(12, PinMode.Output);
		StartCoroutine(BlinkLoop());
	}
	
	// Update is called once per frame
	IEnumerator BlinkLoop() {
		while(true)
		{

			UduinoManager.Instance.digitalWrite(12, State.HIGH);
			yield return new WaitForSeconds(0.5f);
			UduinoManager.Instance.digitalWrite(12, State.LOW);
			yield return new WaitForSeconds(0.5f);
		}
		
	}
}
