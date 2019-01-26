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
