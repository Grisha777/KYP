using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour
{   
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers)            
                r.enabled = false;            
        }
    }
}