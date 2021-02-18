using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel2 : MonoBehaviour
{
    public int level2;
    void OnTriggerEnter(Collider coll1der)
    {
        if (coll1der.tag == "Player")
        {
            Application.LoadLevel(level2);
        }
    }
}

