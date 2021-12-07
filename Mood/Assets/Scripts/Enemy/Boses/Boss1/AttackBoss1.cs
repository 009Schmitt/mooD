using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoss1 : MonoBehaviour
{
    public AttackGeneratorIncreasing boosBall;
    public GameObject shoot;

    public float shootAmount;


    private float attackSpeed, actualTime, ballScale;
    // Start is called before the first frame update
    void Start()
    {
        attackSpeed = 1.5f / shootAmount;
        ballScale = 2 / shootAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (!boosBall.isIncreasing)
        {
            if (actualTime < Time.time)
            {
                Instantiate(shoot, transform.position, new Quaternion());
                shootAmount--;
                boosBall.transform.localScale -= new Vector3(ballScale, ballScale, ballScale);
                actualTime = attackSpeed + Time.time;
                if(boosBall.transform.localScale.x < 0)
                {
                    Destroy(boosBall.gameObject);
                }
            }


        }
    }
}
