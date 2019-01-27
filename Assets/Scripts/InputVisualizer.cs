using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputVisualizer : MonoBehaviour
{

    private RectTransform rectTransform;
    public GameObject letterHolderPrefab;
    public GameObject letterPrefab;
    private List<GameObject> letterHolders;
    private List<GameObject> letters;
    public float Y_POSITION_LEVEL;
    private Sprite[] sprites;

    public void Start()
    {
        //letterHolders = new List<GameObject>();
        //letters = new List<GameObject>();

    }

    public void CreateLetterHolders(int maxNumInput){
        letterHolders = new List<GameObject>();
        float startPosition = -0.5f * (maxNumInput-1);
        for(int i=0; i< maxNumInput; i++){
            letterHolders.Add(Instantiate(letterHolderPrefab, new Vector3(i+startPosition + transform.parent.transform.position.x, transform.parent.transform.position.y + Y_POSITION_LEVEL, 0), Quaternion.identity));
            Debug.Log("Letter holder number " + i + " created! Count of LetterHolders: " + letterHolders.Count);
        }
    }

    public void DeleteNextLetter(){
        letters.RemoveAt(0);
    }

    public void DeleteLetter(int index){
        letters.RemoveAt(index);
    }

    public void StartLettersList(){
        letters = new List<GameObject>();
        sprites = Resources.LoadAll<Sprite>("SpriteLetters");
    }

    public void AddLetter(string s){
        Debug.Log("Letter count a priori: " + letters.Count + ". Letter holders count: " + letterHolders.Count);
        //if(!(letters.Count >= letterHolders.Count)){
            letters.Add(Instantiate(letterPrefab, new Vector3((float) letterHolders[letters.Count].transform.position.x + 0.15f,(float)  letterHolders[letters.Count].transform.position.y + 0.15f,(float)  letterHolders[letters.Count].transform.position.z), Quaternion.identity));
            Debug.Log("La letra escrita es: " + s);
            letters[letters.Count-1].GetComponent<LetterSpriteManager>().setSprites(sprites);
            letters[letters.Count-1].GetComponent<LetterSpriteManager>().ChangeSprite(s);
            Debug.Log("Creada la letra: " + letters[letters.Count-1]);

        /*} else {
            Debug.Log("Se ha pedido crear más letras que espacios permitidos");
        }*/
        Debug.Log("Letter count a posteriori: " + letters.Count + ". Letter holders count: " + letterHolders.Count);
    }




}
