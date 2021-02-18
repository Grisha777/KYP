using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel3 : MonoBehaviour
{
    public int level3;
    void OnTriggerEnter(Collider coll1der)
    {
        if (coll1der.tag == "Player")
        {
            Application.LoadLevel(level3);
        }
    }
}