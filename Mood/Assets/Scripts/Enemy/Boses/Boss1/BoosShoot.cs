using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosShoot : MonoBehaviour
{
    public Transform playerTrans;
    public float moveSpeed;

    public float morre;

    // Start is called before the first frame update
    void Start()
    {
        playerTrans = FindObjectOfType<CharacterController>().GetComponent<Transform>();
        transform.LookAt(playerTrans);
        morre = Time.time + 5;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * moveSpeed);

        if(morre < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
