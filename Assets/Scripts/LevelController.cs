using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int NUMBER_OF_INPUTS;
    public List<string> listChars;
    public GameObject playerPrefab;
    public GameObject inputVisualizer;
    private GameObject player;

    private bool inAction;

    void Start(){
        inAction = false;
        listChars = new List<string>();
        CreateLetterHolders();
        player = Instantiate(playerPrefab);
    }

    private void CreateLetterHolders(){
        inputVisualizer.GetComponent<InputVisualizer>().CreateLetterHolders(NUMBER_OF_INPUTS);
    }

    public void AddLetter(string s){
        if(listChars.Count < NUMBER_OF_INPUTS){
            inputVisualizer.GetComponent<InputVisualizer>().AddLetter(s);
            listChars.Add(s);
        } else {
            Debug.Log("Se ha llegado al número máximo de inputs");
        }
    }

    //Simplemente empieza la co-rutina de SequentialActions
    public void StartActions(){
        if(!inAction){

            StartCoroutine(SequentialActions());
        }

    }

    //Ejecuta cada acción del script CharacterController y pausa un segundo antes de ejecutar la siguiente
    IEnumerator SequentialActions()
     {
         if(listChars.Count == NUMBER_OF_INPUTS){
             inAction = true;
             foreach(string s in listChars){
                 player.GetComponent<CharacterAction>().Action(s);
                 yield return new WaitForSeconds(1f);
             }
             inAction = false;
         }
     }
}
