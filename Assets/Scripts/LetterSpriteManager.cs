using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpriteManager : MonoBehaviour
{
    public int NUMBER_LETTERS_ALPHABET = 27;
    public int MAX_NUMBER_INPUTS = 32;
    private string spriteNames = "SpriteLetters";
    private SpriteRenderer spriteRenderer;
    private Sprite[] sprites;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }

    private int LetterToNumber(string s)
    {
        char c = char.Parse(s);
        int index = ((int)char.ToUpper(c)) - 64;
        return index;
    }

    public void ObtainSprite(string s)
    {
        if (!s.Equals(" ") && !s.Equals("ñ"))
        {
            int pos = LetterToNumber(s);
            // Este switch se usa para cambiar los sprites de a,w,s,d a las flechas
            switch(pos){
                case 4: pos = 28;           // caso d
                        break;
                case 0: pos = 29;           // caso a
                        break;
                case 19: pos = 30;          // caso s
                        break;
                case 23: pos = 31;          // caso w
                        break;
            }
            Debug.Log("" + pos);
            spriteRenderer.sprite = sprites[pos];
        }
        else
        {
            if (s.Equals("ñ"))
            {
                spriteRenderer.sprite = sprites[27];
            }
            else    // caso space " "
            {
                spriteRenderer.sprite = sprites[32];
            }
        }

    }

}
