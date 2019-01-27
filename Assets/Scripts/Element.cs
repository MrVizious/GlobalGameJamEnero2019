using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public bool obstacle;
    public string activationKey;
    public GameObject levelController;

    public GameObject sign;

    public bool isObstacle(){
        return obstacle;
    }

    public void Action(string inputString){
        if(inputString.Equals(activationKey)){
            switch(inputString){
                case "p": 
                            levelController.GetComponent<LevelController>().won = true;
                            LoadSalon();
                     break;
            }
        }
            
    }

    public void ShowActionLetter(){
        sign.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Enseñando la letra del objeto");
    }


    //---------------------------
    //  Colección de acciones
    //---------------------------

    public void LoadSalon(){
        PersistentManagerScript.Instance.ChangeScene("Cocina-Salon");
    }

}
