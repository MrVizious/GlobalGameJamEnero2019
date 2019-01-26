using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [System.Serializable]
    public class TrackedGameObject{
        public GameObject trackedGameObject;
        public int x;
        public int y;
    }

    //[SerializeField]
    public int NUMBER_OF_INPUTS;
    public List<string> listChars;
    public List<TrackedGameObject> trackedGameObjects;
    public TrackedGameObject playerPrefab;
    public GameObject inputVisualizer;
    private GameObject player;

    void Start(){
        listChars = new List<string>();
        InstantiateObjects();
        CreateLetterHolders();

    }

    private void CreateLetterHolders(){
        inputVisualizer.GetComponent<InputVisualizer>().CreateLetterHolders(NUMBER_OF_INPUTS);
    }

    public void AddLetter(string s){
        //TODO Letra temporal, hay que cambiarlo por la de verdad
        if(listChars.Count < NUMBER_OF_INPUTS){
            inputVisualizer.GetComponent<InputVisualizer>().AddLetter(s);
            listChars.Add(s);
        } else {
            Debug.Log("Se ha llegado al número máximo de inputs");
        }
    }

    private void InstantiateObjects(){
        player = Instantiate(playerPrefab.trackedGameObject);
        //CUIDADO TODO Esto utiliza los prefabs en lugar de los objetos creados.
        //Da igual porque en principio no se van a manipular las posiciones de los prefabs, pero hay que ir con ojo
        foreach(TrackedGameObject o in trackedGameObjects){
            Instantiate(o.trackedGameObject, new Vector3(o.x, o.y, 0), Quaternion.identity);
        }
    }

    public void StartMovement(){
        StartCoroutine(SequentialMovement());


    }

    IEnumerator SequentialMovement()
     {

         if(listChars.Count == NUMBER_OF_INPUTS){
             foreach(string s in listChars){
                 player.GetComponent<CharacterMovement>().Move(s);
                 yield return new WaitForSeconds(1f);
             }
         }
         /*
         iTween.MoveTo(tile.gameObject, iTween.Hash("position", destination1, "time", 2f));


         iTween.MoveTo(tile.gameObject, iTween.Hash("position", destination2, "time", 2f));
         yield return new WaitForSeconds(2f);*/

         // ... other sequential actions here?
     }

}
