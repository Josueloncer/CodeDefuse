using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour {

    Material m_Material;

    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        m_Material.color = Color.blue;
    }

    private void Update()
    {
        if (Input.GetKeyUp("right shift") == true)
        {
            if(m_Material.color == Color.blue)
            {
                m_Material.color = Color.yellow;
            }

            else
            {
                m_Material.color = Color.blue;
            }
        }
    }
}
