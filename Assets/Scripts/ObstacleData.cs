using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleData : MonoBehaviour
{
    //  LOS DATOS TIENEN QUE ESTAR PUESTOS COMO CON UN FLIP Y
    private int[,] recibidorData = new int [,]{{0,1,1,1,0},
                                               {1,0,0,0,1},
                                               {1,0,0,0,1},
                                               {1,0,0,0,1},
                                               {1,1,0,0,1},
                                               {1,1,0,0,1},
                                               {0,1,0,1,0}};
    private int[,] salonData = new int [,]{{0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                                           {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,1,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,1,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,1,1},
                                           {1,0,0,0,0,1,0,1,0,0,0,0,0,1,1},
                                           {0,1,1,1,0,0,1,0,1,1,1,1,1,1,0}};
    private int[,] garajeData = new int [,]{{0,1,0,1,1,1,1,0},
                                            {1,0,0,0,0,0,0,1},
                                            {1,0,0,0,0,0,0,1},
                                            {1,0,0,0,0,0,0,1},
                                            {1,0,0,0,0,0,0,1},
                                            {1,0,0,0,0,0,0,1},
                                            {1,0,0,0,0,0,0,1},
                                            {0,1,1,1,1,1,1,0}};


    public int[,] getObstacleData(string levelName){
        switch(levelName){
            case "Recibidor": return recibidorData;
            case "Salon":
            case "Cocina": return salonData;
            case "Garaje": return garajeData;
            default: return null;
        }
    }
}
