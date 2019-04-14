using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarNetWorkManager : MonoBehaviour
{
    GameObject _NetworkManger;

    void Start()
    {
        _NetworkManger = GameObject.Find("_NetworkManager");

        if (_NetworkManger == null)
        {
            //
        }
        else
        {
            Destroy(_NetworkManger);
        }
    }
}
