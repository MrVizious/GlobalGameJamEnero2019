﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleData : MonoBehaviour
{
    private int[,] recibidorData = new int [,]{{0,1,0,1,0},
                                               {1,0,0,0,1},
                                               {1,0,0,0,1},
                                               {1,0,0,0,1},
                                               {1,0,0,0,1},
                                               {0,1,0,1,0}};
    private int[,] salonData = new int [,]{{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,1,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                           {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                           {1,1,1,1,0,1,1,0,1,1,1,1,1,1,1}}


    public int[,] getObstacleData(string levelName){
        switch(levelName){
            case "Recibidor": return recibidorData;
            case "Salon":
            case "Cocina": return salonData;
            default: return null;
        }
    }
}
