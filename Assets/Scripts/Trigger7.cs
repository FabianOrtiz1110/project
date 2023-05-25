using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger7 : MonoBehaviour
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
            GUI.Box(new Rect(Screen.width / 2 - 700, Screen.height - 850, 270, 40), "\"I should just head back\"");
        }
    }
}