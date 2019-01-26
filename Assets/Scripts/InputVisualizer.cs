using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputVisualizer : MonoBehaviour
{

    private Text inputArray;
    private RectTransform rectTransform;
    private List<string> listChars;
    public GameObject keyChecker;
    string res;

    public void Start()
    {
        inputArray = GetComponent<Text>();
        getListFromKeyChecker();
        initializeText();
    }

    private void initializeText()
    {
        foreach (string s in listChars)
        {
            res += s;
        }
        inputArray.text = res;
    }

    //Llama al método getListChars de un GameObject que tenga el script KeyChecker que se le haya dado en el inspector
    private void getListFromKeyChecker()
    {
        listChars = keyChecker.GetComponent<KeyChecker>().getListChars();
    }
}
