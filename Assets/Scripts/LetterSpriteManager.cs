using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpriteManager : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite[] sprites;

    void Start()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //ChangeSprite("d");
    }

    private int LetterToNumber(string s)
    {
        char c = char.Parse(s);
        //int index = ((int)char.ToUpper(c)) - 65;
        int index = c-'a';
        Debug.Log("Value of the input " + s + ": " + index);
        return index;
    }

    public void setSprites(Sprite[] newSprites){
        sprites = newSprites;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite(string s)
    {

        if (!s.Equals(" ") && !s.Equals("ñ"))
        {
            int pos = LetterToNumber(s);
            // Este switch se usa para cambiar los sprites de a,w,s,d a las flechas
            switch(pos){
                case 3: pos = 27;           // caso d
                        break;
                case 0: pos = 28;           // caso a
                        break;
                case 18: pos = 30;          // caso w
                        break;
                case 22: pos = 29;          // caso s
                        break;
            }
            Debug.Log("Num " + pos);
            spriteRenderer.sprite = sprites[pos];
        }
        else
        {
            if (s.Equals("ñ"))
            {
                spriteRenderer.sprite = sprites[26];
            }
            else    // caso space " "
            {
                spriteRenderer.sprite = sprites[31];
            }
        }

    }

}
