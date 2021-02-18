using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public int level;
    void OnTriggerEnter(Collider coll1der)
    {
        if(coll1der.tag =="Player")
        {
            Application.LoadLevel(level);
        }
    }
}
