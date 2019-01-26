using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour
{

    private Vector3 target;
    public float speed;
    public GameObject tileController;


    void Start(){
        target = transform.position;
    }

    public void Action(string s){
        switch(s){
            case "w":
                    if(tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y+1)){
                    target = transform.position + new Vector3(0,1,0);
                    }
                    break;
            case "a":
                    if(tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x-1, (int)transform.position.y)){
                    target = transform.position + new Vector3(-1,0,0);
                    }
                    break;
            case "s":
                    if(tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y-1)){
                    target = transform.position + new Vector3(0,-1,0);
                    }
                    break;
            case "d":
                    if(tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x+1, (int)transform.position.y)){
                    target = transform.position + new Vector3(1,0,0);
                    }
                    break;
            case " ": Debug.Log("Pausa hecha");
                    break;
            default:
                    sendActions(s);
                    break;

        }

    }

    void Update(){
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    private void sendActions(string inputString){
        List<GameObject> listElementsAround = tileController.GetComponent<TileController>().getElementsAround((int)transform.position.x, (int)transform.position.y);
        foreach (GameObject o in listElementsAround) {
            o.GetComponent<Element>().Action(inputString);
        }
    }
}
