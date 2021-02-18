using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3 : MonoBehaviour
{
    public bool End;
    public GameObject dialog3;
    void Update()
    {
        if (End == true)
        {
            Time.timeScale = 1;
            dialog3.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            dialog3.SetActive(true);
        }
    }
}
