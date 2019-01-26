using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public void StartMovement(List<string> listChars)
    {
        foreach(string s in listChars){
            switch(s){
                case "w":
                        Debug.Log("Posición actual del player: " + transform.position.ToString());
                        transform.position += new Vector3(0,1,0);
                        break;
                default: Debug.Log("Letra introducida no corecta!: "+ s);
                        break;
            }

        }
    }
}
