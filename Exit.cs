using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Body_Player")
        {
            /*Application.Quit();*/
            Cursor.lockState = CursorLockMode.None;
            Application.Quit();
        }

    }
}
