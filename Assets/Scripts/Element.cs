using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public bool obstacle;
    public string activationKey;

    public bool isObstacle(){
        return obstacle;
    }

    public void Action(string inputString){
        if(inputString.Equals(activationKey)){
            Debug.Log("Acción realizada por " + gameObject.name);
        }
    }
}

//TODO arreglar lo de las letras que no aparecen

// TODO al entrar por una puerta por ejemplo, pisar a un gato (creo que esto se comprueba en el mismo método de check collision)

// TODO Singleton
// TODO inventario
