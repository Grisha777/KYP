using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public Transform Points;
    public GameObject Prefabs;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Instantiate(Prefabs, Points.position, Quaternion.identity);
        }
    }
}
