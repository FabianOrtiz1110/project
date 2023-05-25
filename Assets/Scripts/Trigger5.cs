using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger5 : MonoBehaviour

{
    public GameObject WALL;
    public AudioSource playSound;
    private bool displayBox = false;

    void OnTriggerEnter(Collider other)
    {
        displayBox = true;
        Destroy(gameObject, 7f);
        playSound.Play();
        Destroy(WALL);
    }

    void OnGUI()
    {
        if (displayBox)
        {
            GUI.Box(new Rect(Screen.width / 2 - 700, Screen.height - 850, 270, 40), "\"Oh, its just a cat, I should go back\"");
        }
    }
}

