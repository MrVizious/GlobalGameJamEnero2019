using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeyChecker : MonoBehaviour
{
    [SerializeField]
    private List<string> listChars;

    public void Start(){
        listChars = new List<string>();
    }

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            string inputKey = Input.inputString;
            if(inputKey.Length==1){
                listChars.Add(Input.inputString);
                Debug.Log("One letter saved: " + Input.inputString);
            } else{
                Debug.Log("More than one letter inputted, not saved");
            }
        }
    }

    public List<string> getListChars()
    {
        return this.listChars;
    }
}
