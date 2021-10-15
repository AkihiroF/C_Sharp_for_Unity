using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Menu_Paused : MonoBehaviour
{
    public GameObject menuPaused;
    public Move_Cam crosshair;
    [SerializeField] KeyCode keyMenuPaused;
    public bool isMenuPaused = false;
    
    void Start()
    {
        menuPaused.SetActive(false);
    }
    public void Resume()
    {
        isMenuPaused = false;
    }

    void Update()
    {
        ActiveMenu();
    }
    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            crosshair.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false);
            crosshair.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }
}