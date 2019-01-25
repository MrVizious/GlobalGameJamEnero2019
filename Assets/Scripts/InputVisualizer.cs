using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputVisualizer : MonoBehaviour
{
    Text inputArray;
    public Font m_Font;
    private List<string> listChars;
    public GameObject keyChecker;


    void Start()
    {

    }

    //Llama al método getListChars de un GameObject que tenga el script KeyChecker que se le haya dado en el inspector
    private void getListFromKeyChecker(){
        listChars = keyChecker.GetComponent<KeyChecker>().getListChars();
        foreach(string s in listChars){
            Debug.Log(s);
        }
    }
}
