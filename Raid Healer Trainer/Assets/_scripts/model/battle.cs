using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle {
    
    public Vector3 AllySpawnPoint { get; protected set; }
    public Vector3 EnnemySpawnPoint { get; protected set; }
    public List<minion> AllyList { get; protected set; }
    public List<minion> EnnemyList { get; protected set; }

    public battle(Vector3 ennemySpawnPoint,Vector3 allySpawnPoint,List<minion> allyList, List<minion> ennemyList )
    {
        AllyList = allyList;
        EnnemyList = ennemyList;
        AllySpawnPoint = allySpawnPoint;
        EnnemySpawnPoint = ennemySpawnPoint;

    }

    //Fonction retournant la position a laquelle spawn le nouvel ally
    public Vector3 spawnAlly(int offset)
    {
        Vector3 characterSpawnPoint = AllySpawnPoint;
        characterSpawnPoint.x= characterSpawnPoint.x + offset;
        characterSpawnPoint.z = 0;
        return characterSpawnPoint;
    }

    //Fonction retournant la position a laquelle spawn le nouvel ennemy

    public Vector3 spawnEnnemy(int offset)
    {
        Vector3 characterSpawnPoint = EnnemySpawnPoint;
        characterSpawnPoint.x = characterSpawnPoint.x + offset;
        characterSpawnPoint.z = 0;
        return characterSpawnPoint;

    }

    
}
