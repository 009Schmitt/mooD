using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public LayerMask enemyMask;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("Atirei");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.forward, out hit, 100000, enemyMask))
            {
                hit.collider.GetComponent<EnemyBasic>().Die();
                print("Acertou");
            }
        }





    }
}
