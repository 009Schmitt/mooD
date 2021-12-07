using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Behavior : MonoBehaviour
{
    public float life;
    public Animator leftArm, rightArm;
    public GameObject attackSphere;
    public Transform[] positions;
    public Transform spawnAttackPosition;
    public AttackBoss1 bossAttack;

    //public float atackSpeed;

    private float actualTime;
    private bool attacking;
    // Start is called before the first frame update
    void Start()
    {
        attacking = false;
        actualTime = Time.time + AttackSpeed();
        print(actualTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (actualTime < Time.time && !attacking)
        {
            rightArm.SetBool("Start", true);
            leftArm.SetBool("Start", true);
            attacking = true;
            Instantiate(attackSphere, spawnAttackPosition.position, new Quaternion());
            bossAttack = FindObjectOfType<AttackBoss1>();
            bossAttack.shootAmount = 8 + (40 - life);
        }

        if (attacking)
        {
            if (bossAttack.shootAmount < 2)
            {
                attacking = false;
                rightArm.SetBool("Start", false);
                leftArm.SetBool("Start", false);
                actualTime = Time.time + AttackSpeed();
            }
        }

    }

    public void Hurt()
    {
        if (!attacking)
            life--;
    }

    private float AttackSpeed()
    {
        return 5 + life / 10;
    }

}
