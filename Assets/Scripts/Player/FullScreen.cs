using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    void Start()
    {
        // Set the game to run in full screen mode
        Screen.fullScreen = true;
    }

    void Update()
    {
        // Toggle between full screen and windowed mode when the F key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}