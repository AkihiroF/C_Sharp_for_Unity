using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioControl : MonoBehaviour
{
    
    public Menu_Paused pause;
    public VideoPlayer videoPlayer;
    public bool play = false;

    public void Update()
    {
        if (play)
        {
            PlayPause();
        }
        else
        {
            videoPlayer.Pause();
        }
        
    }
    void PlayPause()
    {
            if (pause.isMenuPaused)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
    }
}
