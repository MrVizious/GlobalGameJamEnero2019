using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeyChecker : MonoBehaviour
{
    [SerializeField]
    private List<char> listChars;

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            listChars.Add((char)Input.anyKeyDown);
            Debug.Log(Input.inputString);
        }
    }

    public List<char> getListChars()
    {
        return this.listChars;
    }
}
