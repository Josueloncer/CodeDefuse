using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour {

    Material m_Material;

    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        m_Material.color = Color.green;
    }

    private void Update()
    {
        if (Input.GetKeyUp("left shift") == true)
        {
            if(m_Material.color == Color.green)
            {
                m_Material.color = Color.red;
            }

            else
            {
                m_Material.color = Color.green;
            }
        }
    }
}
