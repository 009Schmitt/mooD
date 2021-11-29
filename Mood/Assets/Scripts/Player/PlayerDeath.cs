using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathCam;


    

    public void Die()
    {
        //List<EnemyBasic> enemies = Resources.FindObjectsOfTypeAll(typeof(EnemyBasic));

        //foreach (var item in Resources.FindObjectsOfTypeAll(typeof(EnemyBasic)))
        //{
        //    Destroy(item);
        //}


        Cursor.lockState = CursorLockMode.Confined;
        deathCam.SetActive(true);
        Destroy(gameObject);
    }
}
