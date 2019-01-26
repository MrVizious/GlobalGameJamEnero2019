using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject pauseMenuUI;

    void Start(){
        pauseMenuUI.SetActive(false);
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
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            Debug.Log("El juego se ha resumido");
    }

    public void PauseGame(){
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            Debug.Log("El juego se ha pausado");
    }

    // Application.Quit() solo funcionará si el juego se ha buildeado
    public void QuitGame(){
        Debug.Log("Quitting game");
        Application.Quit();
    }

}
