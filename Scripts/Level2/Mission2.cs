using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission2 : MonoBehaviour
{
    public bool End;
    public GameObject dialog2;
    void Update()
    {
        if (End == true)
        {
            Time.timeScale = 1;
            dialog2.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            dialog2.SetActive(true);
        }
    }
}
