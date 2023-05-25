
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    private bool displayBox = false;

    void OnTriggerEnter(Collider other)
    {
        displayBox = true;
        Destroy(gameObject, 7f);
    }

    void OnGUI()
    {
        if (displayBox)
        {
            GUI.Box(new Rect(Screen.width / 2 - 700, Screen.height - 850, 180, 40), "Visit the bedroom across");
        }
    }
}