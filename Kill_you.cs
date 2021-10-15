using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kill_you : MonoBehaviour
{
    public GameObject menuPaused;
    public Move_Cam crosshair;
    public bool a;
    public Move_Mouse mouse;
    public Menu_Paused paused;
    
    private void Start()
    {
        menuPaused.SetActive(false);
    }
    void Update()
    {
        if (a)
        {
            crosshair.enabled = false;
            Time.timeScale = 0f;
            mouse.enabled = false;
            paused.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Body_Player")
        {
            a = true;
            menuPaused.SetActive(true);
        }

    }
    
}
