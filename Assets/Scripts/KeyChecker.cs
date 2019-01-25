using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeyChecker : MonoBehaviour
{
    [SerializeField]
    private char c;
    
    public void Update(){
            if(Input.anyKeyDown){
                Debug.Log(Input.inputString);
            }
    }
}
