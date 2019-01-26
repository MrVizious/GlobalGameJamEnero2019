using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour
{

    private Vector3 target;
    public float speed;

    void Start(){
        target = transform.position;
    }

    public void Action(string s){
        switch(s){
            case "w":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    target = transform.position + new Vector3(0,1,0);
                    break;
            case "a":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    target = transform.position + new Vector3(-1,0,0);
                    break;
            case "s":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    target = transform.position + new Vector3(0,-1,0);
                    break;
            case "d":
                    Debug.Log("Posición actual del player: " + transform.position.ToString());
                    target = transform.position + new Vector3(1,0,0);
                    break;
            case " ": Debug.Log("Pausa hecha");
                    break;
            default: Debug.Log("Letra introducida no corecta!: "+ s);
                    break;

        }

    }

    void Update(){
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

}
