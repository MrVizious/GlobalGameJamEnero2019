using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;

    void Start(){
        GameIsPaused = false;
    }

    public void PauseManager(){
        if(GameIsPaused){
            ResumeGame();
        } else {
            PauseGame();
        }
    }

    public void ResumeGame(){
            //pauseMenuUI.setActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
    }

    public void PauseGame(){
            //pauseMenuUI.setActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
    }

}
