using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LevelController))]
public class LevelControllerDebug : MonoBehaviour
{
    //Booleanos para los diferentes tests
    public bool debugMovement;


    private LevelController levelController;
    // Start is called before the first frame update
    void Start()
    {
        levelController = GetComponent<LevelController>();
        if(debugMovement){
            DebugMovement();
        }
    }

    private void DebugMovement(){
        Debug.Log("Debugging del movimiento ha comenzado!");
        levelController.StartMovement();
    }
}
