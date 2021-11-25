using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotGun : MonoBehaviour
{
    public Animator shotGunAnimations,ammoLeft,AmmoRight;
    public PlayerShot playerShot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerShot.reloading)
        {
            shotGunAnimations.SetBool("Reload", true);
            ammoLeft.SetBool("Reload", true);
            AmmoRight.SetBool("Reload", true);
        }
        else
        {
            shotGunAnimations.SetBool("Reload", false);
            ammoLeft.SetBool("Reload", false);
            AmmoRight.SetBool("Reload", false);
        }
    }
}
