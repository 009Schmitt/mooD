using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGeneratorIncreasing : MonoBehaviour
{
    public bool isIncreasing;
    public float increasingMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        isIncreasing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isIncreasing)
        {
            transform.localScale += new Vector3(.034f, .034f, .034f) * increasingMultiplier;
            if(transform.localScale.x > 2)
            {
                isIncreasing = false;
            }
        }
        


    }
}
