using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission1 : MonoBehaviour
{
    public bool End;
    public GameObject dialog1;
    void Update()
    {
        if(End == true)
        {
            Time.timeScale = 1;
            dialog1.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0;
            dialog1.SetActive(true);
        }
    }
}
