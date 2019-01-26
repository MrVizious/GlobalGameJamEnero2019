using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public string levelName;
    public List<GameObject> elements;
    //public GameObject prefabObstacle;

    private int[,] obstacleMatrix;

    void Start(){
        FillObstacleMatrix();
        //DrawObstacles();
        FillObstacleMatrixWithElements();
    }

    private void FillObstacleMatrix(){
        obstacleMatrix = GetComponent<ObstacleData>().getObstacleData(levelName);
        Debug.Log("Matriz llena con raw data");
        /* Comprobación de Matriz llena
        string s = "";
        for(int y=0; y<obstacleMatrix.GetLength(0); y++){
            for(int x=0; x<obstacleMatrix.GetLength(1); x++){
                s+=obstacleMatrix[y,x];
            }
            s+="\n";
        }
        Debug.Log(s);
        */
    }

    private void FillObstacleMatrixWithElements(){
        foreach(GameObject o in elements){
            if(o.GetComponent<Element>().isObstacle()){
                obstacleMatrix[(int)Mathf.Round(o.transform.position.y), (int)Mathf.Round(o.transform.position.x)] = 1;
                Debug.Log("Elemento obstáculo añadido!");
            }
        }
    }
    

    public List<GameObject> getElementsAround(int x, int y){
        List<GameObject> elementsAround = new List<GameObject>();
        foreach(GameObject o in elements){
            if((int) Mathf.Round(o.transform.position.x) == x+1 && (int) Mathf.Round(o.transform.position.y) == y) elementsAround.Add(o);
            else if((int) Mathf.Round(o.transform.position.x-1) == x && (int) Mathf.Round(o.transform.position.y) == y) elementsAround.Add(o);
            else if((int) Mathf.Round(o.transform.position.x) == x && (int) Mathf.Round(o.transform.position.y) == y+1) elementsAround.Add(o);
            else if((int) Mathf.Round(o.transform.position.x) == x && (int) Mathf.Round(o.transform.position.y) == y-1) elementsAround.Add(o);
        }
        return elementsAround;
    }

    //TODO checkPossibleAction

    public bool CheckPosibleMovement(int x, int y){
        return obstacleMatrix[y,x] != 1;
    }

    //Solo para debugging
    /*
    private void DrawObstacles(){
        for(int y=0; y<obstacleMatrix.GetLength(0); y++){
            for(int x=0; x<obstacleMatrix.GetLength(1); x++){
                if(obstacleMatrix[y,x]==1) Instantiate(prefabObstacle, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }*/


}
