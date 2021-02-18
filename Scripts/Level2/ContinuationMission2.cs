using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuationMission2 : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    private bool text1 = true;
    public Mission2 next;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text1 == true)
            {
                text1 = false;
            }
            else
            {
                text1 = true;
                next.End = true;
            }
        }
        if (text1 == true)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);
        }
        else
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
    }
}
