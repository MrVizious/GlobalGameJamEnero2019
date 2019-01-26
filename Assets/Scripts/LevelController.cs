using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [System.Serializable]
    public class TrackedGameObject{
        public GameObject trackedGameObject;
        public int x;
        public int y;
    }

    //[SerializeField]
    public List<string> listChars;
    public List<TrackedGameObject> trackedGameObjects;
    public TrackedGameObject playerPrefab;

    private GameObject player;

    void Start(){
        InstantiateObjects();
    }


    private void InstantiateObjects(){
        player = Instantiate(playerPrefab.trackedGameObject);
        //CUIDADO TODO Esto utiliza los prefabs en lugar de los objetos creados.
        //Da igual porque en principio no se van a manipular las posiciones de los prefabs, pero hay que ir con ojo
        foreach(TrackedGameObject o in trackedGameObjects){
            Instantiate(o.trackedGameObject, new Vector3(o.x, o.y, 0), Quaternion.identity);
        }
    }

    public void StartMovement(){
        player.GetComponent<CharacterMovement>().StartMovement(listChars);
    }
}
