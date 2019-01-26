using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO hay que hacer dos métodos: uno para inicializar los espacios vacios y otro para ir llenandolos uno a uno


public class InputController : MonoBehaviour
{

    public GameObject levelController;

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            string inputKey = Input.inputString;
            if(inputKey.Length==1){
                levelController.GetComponent<LevelController>().AddLetter(inputKey);
                Debug.Log("One letter saved: " + "*" + inputKey + "*");
            } else{
                Debug.Log("More than one letter inputted, not saved. Input was: " + inputKey);
            }
        }
    }
}
