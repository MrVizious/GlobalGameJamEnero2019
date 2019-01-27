using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour
{

    private Vector3 target;
    public float speed;
    public GameObject tileController;
    public Animator animator;


    void Start()
    {
        target = transform.position;
    }

    public void Action(string s)
    {
        switch (s)
        {
            case "w":
                animator.SetBool("LookingSide", false);
                animator.SetBool("LookingSideLeft", false);
                animator.SetBool("LookingBack", true);
                animator.SetBool("LookingForward", false);
                Debug.Log("Se puede mover? " + tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y + 1));
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y + 1))
                {
                    target = transform.position + new Vector3(0, 1, 0);

                }
                break;
            case "a":
                animator.SetBool("LookingSide", false);
                animator.SetBool("LookingBack", false);
                animator.SetBool("LookingForward", false);
                animator.SetBool("LookingSideLeft", true);
                Debug.Log("Se puede mover? " + tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x - 1, (int)transform.position.y));
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x - 1, (int)transform.position.y))
                {
                    target = transform.position + new Vector3(-1, 0, 0);
                }
                break;
            case "s":
                animator.SetBool("LookingSide", false);
                animator.SetBool("LookingBack", false);
                animator.SetBool("LookingForward", true);
                animator.SetBool("LookingSideLeft", false);
                Debug.Log("Se puede mover? " + tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y - 1));
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y - 1))
                {
                    target = transform.position + new Vector3(0, -1, 0);
                }
                break;
            case "d":
                animator.SetBool("LookingSide", true);
                animator.SetBool("LookingBack", false);
                animator.SetBool("LookingForward", false);
                animator.SetBool("LookingSideLeft", false);
                Debug.Log("Se puede mover? " + tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x + 1, (int)transform.position.y));
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x + 1, (int)transform.position.y))
                {
                    target = transform.position + new Vector3(1, 0, 0);

                }
                break;
            case " ":
                Debug.Log("Pausa hecha");
                break;
            default:
                sendActions(s);
                break;

        }

    }

    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    private void showActions(){
        List<GameObject> listElementsAround = tileController.GetComponent<TileController>().getElementsAround((int)transform.position.x, (int)transform.position.y);
        foreach (GameObject o in listElementsAround)
        {
            o.GetComponent<Element>().showActionLetter();
        }
    }

    private void sendActions(string inputString)
    {
        List<GameObject> listElementsAround = tileController.GetComponent<TileController>().getElementsAround((int)transform.position.x, (int)transform.position.y);
        foreach (GameObject o in listElementsAround)
        {
            o.GetComponent<Element>().Action(inputString);
        }
    }
}
