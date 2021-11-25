using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerStage01 : MonoBehaviour
{
    public GameObject enemy,boss;


    public void SpawnEnemies()
    {
        int qtdEnemies = Random.Range(6,11);

        // 12-25
        for (int i = 0; i < qtdEnemies; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(12f, 25f), .3f, Random.Range(12f, 25f)), 
                new Quaternion());
        }
    }
    
}
