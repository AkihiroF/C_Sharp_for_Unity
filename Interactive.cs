using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public float RayDistance;
    public new AudioControl audio;
    
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * RayDistance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Animation animation = hit.collider.gameObject.GetComponent<Animation>();
            if (animation)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    animation.Open();
                }
            }
            Screen_Change screen = hit.collider.gameObject.GetComponent<Screen_Change>();

            if (screen)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Cursor.lockState = CursorLockMode.None;
                    screen.ChangeScene();
                }
            }
            AudioControl audio = hit.collider.gameObject.GetComponent<AudioControl>();
            audioPlay();
        }
    }
    void audioPlay()
    {
        if (audio)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                audio.play = !audio.play;
            }
        }
    }
}
