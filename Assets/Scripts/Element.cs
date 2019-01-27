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
            switch(inputString){
                "p": LoadSalon();
                     break;
            }
        }
    }

    public void ShowActionLetter(){
        Debug.Log("Enseñando la letra del objeto " + gameObject.Name);
    }


    //---------------------------
    //  Colección de acciones
    //---------------------------

    public void LoadSalon(){
        PersistentManagerScript.Instance.ChangeScene("Cocina - Salon")
    }

}
