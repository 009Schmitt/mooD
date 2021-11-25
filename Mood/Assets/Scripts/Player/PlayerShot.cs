using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShot : MonoBehaviour
{
    public LayerMask enemyMask;

    public Text ammunitionText;
    public ParticleSystem shotEffect;
    public Camera playerCamera;
    public int ammunition;
    public bool reloading;

    private int magazine;
    private float actualTime;
    // Start is called before the first frame update
    void Start()
    {
        magazine = 2;
    }

    // Update is called once per frame
    void Update()
    {
        ammunitionText.text = ammunition.ToString();

        if (Input.GetButtonDown("Fire1") && magazine > 0 && !reloading)
        {
            shotEffect.Play();
            magazine--;
            RaycastHit hit;
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward,
                out hit, 1000, enemyMask))
            {
                EnemyBasic enemy;
                if (hit.transform.TryGetComponent(out enemy))
                {
                    enemy.Die();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && magazine < 2 && ammunition > 0)
        {
            actualTime = Time.time + 1;
            reloading = true;
            while (magazine < 2 && ammunition > 0)
            {
                magazine++;
                ammunition--;
            } 
        }
        if (actualTime < Time.time)
        {
            reloading = false;
        }

    }
}
