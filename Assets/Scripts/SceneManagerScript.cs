using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void ChangeScene(string s){
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }
}
