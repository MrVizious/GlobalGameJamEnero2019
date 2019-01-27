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
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y + 1))
                {
                    target = transform.position + new Vector3(0, 1, 0);
                    animator.SetBool("LookingSide", false);
                    animator.SetBool("LookingBack", true);
                    animator.SetBool("LookingForward", false);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
                break;
            case "a":
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x - 1, (int)transform.position.y))
                {
                    target = transform.position + new Vector3(-1, 0, 0);
                    animator.SetBool("LookingSide", true);
                    animator.SetBool("LookingBack", false);
                    animator.SetBool("LookingForward", false);
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                break;
            case "s":
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x, (int)transform.position.y - 1))
                {
                    target = transform.position + new Vector3(0, -1, 0);
                    animator.SetBool("LookingSide", false);
                    animator.SetBool("LookingBack", false);
                    animator.SetBool("LookingForward", true);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
                break;
            case "d":
                if (tileController.GetComponent<TileController>().CheckPosibleMovement((int)transform.position.x + 1, (int)transform.position.y))
                {
                    target = transform.position + new Vector3(1, 0, 0);
                    animator.SetBool("LookingSide", true);
                    animator.SetBool("LookingBack", false);
                    animator.SetBool("LookingForward", false);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
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

    private void sendActions(string inputString)
    {
        List<GameObject> listElementsAround = tileController.GetComponent<TileController>().getElementsAround((int)transform.position.x, (int)transform.position.y);
        foreach (GameObject o in listElementsAround)
        {
            o.GetComponent<Element>().Action(inputString);
        }
    }
}
