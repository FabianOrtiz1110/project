using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private float elapsedTime;
    private Light flashlight;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        flashlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 895)
        {
            flashlight.enabled = false;
        }
    }
}