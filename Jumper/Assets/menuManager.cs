using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if(isPaused==true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }


    private bool isPaused = false;

}

