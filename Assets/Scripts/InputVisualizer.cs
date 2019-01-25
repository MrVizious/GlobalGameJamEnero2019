using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputVisualizer : MonoBehaviour
{
    Text inputArray;
    public Font m_Font;
    private List<char> listChars;


    void Update()
    {
        listChars = getListChars();
        Debug.Log(listChars.ToString());
    }
}
