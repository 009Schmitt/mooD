using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Door porta;
    public GameObject cristal;

    public bool activated;

    public void Start()
    {
        activated = false;
    }

    public void Interacted()
    {
        if (!activated)
        {
            porta.Abrir();
            cristal.SetActive(true);
        }
        activated = true;
    }


}
