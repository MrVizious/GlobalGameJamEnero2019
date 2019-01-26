﻿using System.Collections;
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
        letterHolders = new List<GameObject>();
        letters = new List<GameObject>();
        sprites = Resources.LoadAll<Sprite>("SpriteLetters");
    }


    public void CreateLetterHolders(int maxNumInput){
        float startPosition = -0.5f * (maxNumInput-1);
        for(int i=0; i< maxNumInput; i++){
            letterHolders.Add(Instantiate(letterHolderPrefab, new Vector3(i+startPosition, Y_POSITION_LEVEL, 0), Quaternion.identity));
        }
    }

    public void AddLetter(string s){
        if(!(letters.Count >= letterHolders.Count)){
            letters.Add(Instantiate(letterPrefab, letterHolders[letters.Count].transform));
            Debug.Log("La letra escrita es: " + s);
            letters[letters.Count-1].GetComponent<LetterSpriteManager>().setSprites(sprites);
            letters[letters.Count-1].GetComponent<LetterSpriteManager>().ChangeSprite(s);
            Debug.Log("Creada la letra: " + letters[letters.Count-1]);

        } else {
            Debug.Log("Se ha pedido crear más letras que espacios permitidos");
        }
    }




}
