using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public LayerMask interactMask;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Physics.CheckSphere(transform.position,.7f,interactMask))
        {
            Collider[] col = Physics.OverlapSphere(transform.position,.7f,interactMask);

            foreach (var item in col)
            {
                DoorButton porta;
                if (item.TryGetComponent(out porta))
                {
                    porta.Interacted();
                }
            }
        }        
    }
}
