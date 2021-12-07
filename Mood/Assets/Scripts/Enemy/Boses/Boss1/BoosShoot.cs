using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosShoot : MonoBehaviour
{
    public Transform playerTrans, sphereEnd;
    public float moveSpeed;
    public LayerMask playerLayer, otherThingsLayer;

    //public float morre;

    // Start is called before the first frame update
    void Start()
    {
        playerTrans = FindObjectOfType<CharacterController>().GetComponent<Transform>();
        transform.LookAt(playerTrans);
        //morre = Time.time + 5;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * moveSpeed);

        //radius .3f;
        if (Physics.CheckSphere(sphereEnd.position, .3f, otherThingsLayer))
        {
            if (Physics.CheckSphere(sphereEnd.position, .3f, playerLayer))
            {
                FindObjectOfType<PlayerDeath>().Die();
            }

            Destroy(gameObject);
        }





        //if(morre < Time.time)
        //{
        //    Destroy(gameObject);
        //}
    }
}
