using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentManagerScript : MonoBehaviour
{
    public static PersistentManagerScript Instance {get; private set;}

    public string SceneName;
    
    private void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void ChangeScene(string s){
        SceneName = s;
        SceneManager.LoadScene(s, LoadSceneMode.Single);

    }

    public void RestartScene(){
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
