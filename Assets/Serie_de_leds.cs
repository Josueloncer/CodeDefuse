using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serie_de_leds : MonoBehaviour {

    int led_red = 0; // Led rojo a pin 0
    int led_green = 1; //Led verde a pin 1

    // Use this for initialization
    void Start () {
        /*
        pinMode(led_red, OUTPUT);
        pinMode(led_green, OUTPUT);*/

    }
	
	// Update is called once per frame
	void Update () {

       /* void loop()
        {
            // Prende el led verde y apaga el rojo
            digitalWrite(led_red, LOW);
            digitalWrite(led_green, HIGH);
            delay(2000);    // 2 seg;

            // Prende el led rojo y apaga el verde
            digitalWrite(led_red, HIGH);
            digitalWrite(led_green, LOW);
            delay(2000);  // 2 seg */
        }
}
