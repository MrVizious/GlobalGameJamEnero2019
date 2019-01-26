using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

// TODO hay que hacer dos métodos: uno para inicializar los espacios vacios y otro para ir llenandolos uno a uno


public class InputController : MonoBehaviour
{

    public GameObject levelController;

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            string inputKey = Input.inputString;
            if(inputKey.Length==1 && (ValidKey(inputKey) || inputKey.Equals(" "))){
                levelController.GetComponent<LevelController>().AddLetter(inputKey);
            } else{
                Debug.Log("Input not correct, not saved. Input was: *" + inputKey + "*");
            }
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            levelController.GetComponent<LevelController>().StartMovement();
        }
    }

    private bool ValidKey(string s){
        return Regex.IsMatch(s, @"^[a-z]+$");
    }
}
