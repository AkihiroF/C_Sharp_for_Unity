using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen_Change : MonoBehaviour
{
	public int screen;
    public void ChangeScene(int screneid)
	{
		SceneManager.LoadScene (screneid);
	}

    internal void ChangeScene()
    {
		ChangeScene(screen);
    }
}
