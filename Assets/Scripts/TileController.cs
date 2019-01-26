using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public string levelName;
    public List<GameObject> elements;
    public GameObject prefabObstacle;

    private int[,] obstacleMatrix;

    void Start(){
        FillObstacleMatrix();
        FillObstacleMatrixWithElements();
        DrawObstacles();
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
                obstacleMatrix[(int)o.transform.position.y, (int)o.transform.position.x] = 1;
                Debug.Log("Elemento obstáculo añadido!");
            }
        }
    }

    //Solo para debugging
    private void DrawObstacles(){
        for(int y=0; y<obstacleMatrix.GetLength(0); y++){
            for(int x=0; x<obstacleMatrix.GetLength(1); x++){
                if(obstacleMatrix[y,x]==1) Instantiate(prefabObstacle, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

}
