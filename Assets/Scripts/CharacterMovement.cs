using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public void Move(string s){
        switch(s){
            case "w":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    transform.position += new Vector3(0,1,0);
                    break;
            case "a":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    transform.position += new Vector3(-1,0,0);
                    break;
            case "s":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    transform.position += new Vector3(0,-1,0);
                    break;
            case "d":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    transform.position += new Vector3(1,0,0);
                    break;
            default: Debug.Log("Letra introducida no corecta!: "+ s);
                    break;

        }

    }

    private void SimpleMove(){
        transform.position += new Vector3(0,1,0);
    }

    /*private IEnumerator SmoothMove(Vector3 v, int turn){
        while(moving || counter != turn){
                //Do nothing
        }
        moving = true;
        yield return new WaitForSeconds(2);
        Debug.Log("Waiting for princess to be rescued... in turn " + turn);
        transform.position += v;
        moving = false;
        counter++;
        Debug.Log("Princess was rescued!");
    }*/



}
