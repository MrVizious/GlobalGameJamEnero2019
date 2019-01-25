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

    public List<TrackedGameObject> trackedGameObjects;

    void Start(){
        InstantiateObjects();
    }


    private void InstantiateObjects(){
        foreach(TrackedGameObject o in trackedGameObjects){
            Instantiate(o.trackedGameObject, new Vector3(o.x, o.y, 0), Quaternion.identity);
        }
    }
}
