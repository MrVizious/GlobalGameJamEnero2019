using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    //ESTABAS CREANDO EL ARRAY DE MAPOBJECTS CON EL QUE SE DETERMINARÁN LAS COLISIONES Y LOS OBJETOS COLINDANTES

    public int NUMBER_OF_ROWS;
    public int NUMBER_OF_COLUMNS;
    //Temporal para Debug
    public GameObject pistaVisual;

    private class MapObject{
        public boolean obstacle;
        public GameObject mapObject;

        public MapObject(boolean isObstacle){
            obstacle = isObstacle;
            mapObject = null;
        }
        public MapObject(boolean isObstacle, GameObject newObject){
            obstacle = isObstacle;
            mapObject = newObject;
        }
    }



    private MapObject[][] mapa = new MapObject[NUMBER_OF_COLUMNS][NUMBER_OF_ROWS];
    private List<int> obstacles;
    public int NUMBER_OF_INPUTS;
    public List<string> listChars;
    public GameObject playerPrefab;
    public GameObject inputVisualizer;
    private GameObject player;

    void Start(){
        //TODO extraer esto para usarlo bien en otros niveles
        obstacles = new List<int>(new int[] {1,3,5,9,10,14,15,19,20,24,26,28})

        listChars = new List<string>();
        CreateLetterHolders();
        player = Instantiate(playerPrefab);
    }

    private void CreateLetterHolders(){
        inputVisualizer.GetComponent<InputVisualizer>().CreateLetterHolders(NUMBER_OF_INPUTS);
    }

    public void AddLetter(string s){
        if(listChars.Count < NUMBER_OF_INPUTS){
            inputVisualizer.GetComponent<InputVisualizer>().AddLetter(s);
            listChars.Add(s);
        } else {
            Debug.Log("Se ha llegado al número máximo de inputs");
        }
    }

    //Simplemente empieza la co-rutina de SequentialActions
    public void StartActions(){
        StartCoroutine(SequentialActions());
    }

    //Ejecuta cada acción del script CharacterController y pausa un segundo antes de ejecutar la siguiente
    IEnumerator SequentialActions()
     {
         if(listChars.Count == NUMBER_OF_INPUTS){
             foreach(string s in listChars){
                 player.GetComponent<CharacterAction>().Action(s);
                 yield return new WaitForSeconds(1f);
             }
         }
     }

     private void CreateWalls(){
         foreach(int i in obstacles){
             mapa[i/NUMBER_OF_COLUMNS][i%NUMBER_OF_COLUMNS] = new MapObject(true);
             Instantiate(pistaVisual, New Vector3(i%NUMBER_OF_COLUMNS, i/NUMBER_OF_COLUMNS, 0), Quaternion.identity);
         }
     }
}
