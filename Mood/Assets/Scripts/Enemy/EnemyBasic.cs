using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public Transform player,attack;
    public float moveSpeed;
    public LayerMask playerMask;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterController>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player);//incompleto
        transform.LookAt(new Vector3(player.position.x, .3f, player.position.z));

        transform.Translate(new Vector3(0, 0, moveSpeed / 100));

        if (Physics.CheckSphere(attack.position,.4f,playerMask))
        {
            FindObjectOfType<PlayerDeath>().Die();
        }

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
