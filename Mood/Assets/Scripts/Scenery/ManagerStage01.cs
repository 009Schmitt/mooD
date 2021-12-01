using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerStage01 : MonoBehaviour
{
    public GameObject enemy, boss, globalLight;
    public BoxCollider boosTrigger;
    public LayerMask playerMask;

    private bool started;

    private void Start()
    {
        Instantiate(globalLight);
        started = false;
    }


    private void Update()
    {
        
        if (Physics.CheckBox(boosTrigger.center, boosTrigger.size / 2, new Quaternion(),playerMask) 
            && !started)
        {
            started = true;

            boss.SetActive(true);


            //foreach (var item in Physics.OverlapBox(boosTrigger.center, boosTrigger.size / 2, new Quaternion()))
            //{
            //    if (item.TryGetComponent<CharacterController>(out _))
            //    {
            //        // Fecho a porta e spawn Boss
            //        boss.SetActive(true);
            //    }
            //} 
        }
    }

    public void SpawnEnemies()
    {


        int qtdEnemies = Random.Range(6, 11);

        // 12-25
        for (int i = 0; i < qtdEnemies; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(12f, 25f), .3f, Random.Range(12f, 25f)),
                new Quaternion());
        }
    }

}
