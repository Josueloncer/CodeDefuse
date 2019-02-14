using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_OnlinePlayerPrueba : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement();		
	}

	void Movement() {
         Rigidbody rb = GetComponent<Rigidbody>();
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right);
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.up);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.down); 
     }
}
