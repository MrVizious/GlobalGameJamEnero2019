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

    public List<TrackedGameObject> gameObjects;
}
