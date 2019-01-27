using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int NUMBER_OF_INPUTS;
    public List<string> listChars;
    public GameObject inputVisualizer;
    public GameObject player;
    public GameObject tileController;
    private bool inAction;

    public bool won;


    void Start()
    {
        inAction = false;
        listChars = new List<string>();
        CreateLetterHolders();
    }

    private void CreateLetterHolders()
    {
        inputVisualizer.GetComponent<InputVisualizer>().CreateLetterHolders(NUMBER_OF_INPUTS);
        inputVisualizer.GetComponent<InputVisualizer>().StartLettersList();
    }

    public void AddLetter(string s)
    {
        Debug.Log("Tamaño de listChars: " + listChars.Count);
        if (listChars.Count < NUMBER_OF_INPUTS)
        {
            Debug.Log("Enviando como string el carácter: *" + s + "*");
            inputVisualizer.GetComponent<InputVisualizer>().AddLetter(s);
            listChars.Add(s);
        }
        else
        {
            Debug.Log("Se ha llegado al número máximo de inputs");
        }
    }

    //Simplemente empieza la co-rutina de SequentialActions
    public void StartActions()
    {

        StartCoroutine(SequentialActions());
    }

    //Ejecuta cada acción del script CharacterController y pausa un segundo antes de ejecutar la siguiente
    IEnumerator SequentialActions()
    {

        if (listChars.Count == NUMBER_OF_INPUTS && !inAction)
        {
            inAction = true;
            foreach (string s in listChars)
            {
                player.GetComponent<CharacterAction>().Action(s);
                yield return new WaitForSeconds(1f);
            }
            if(!won){
                   PersistentManagerScript.Instance.RestartScene();
                }

            inAction = false;
        }
    }
}
