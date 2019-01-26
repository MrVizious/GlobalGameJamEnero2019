using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public bool obstacle;

    public bool isObstacle(){
        return obstacle;
    }

    public void Action(){
        Debug.Log("Acción realizada por " + gameObject.name);
    }
}

// TODO al entrar por una puerta por ejemplo, pisar a un gato

// TODO Singleton
// TODO inventario
// TODO menu de pausa
