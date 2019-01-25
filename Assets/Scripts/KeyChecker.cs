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
            //listChars.Add(Input.inputString);
            Debug.Log(Input.inputString);
        }
    }

    public List<string> getListChars()
    {
        return this.listChars;
    }
}
