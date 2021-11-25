using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int buttonQuantity;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonQuantity <= 0)
        {
            if (transform.position.y > -11)
            {
                transform.Translate(new Vector3(0, 0, .2f));
            }
        }
    }

    public void Abrir()
    {
        buttonQuantity--;

        try
        {
            FindObjectOfType<ManagerStage01>().SpawnEnemies();
        }
        catch (System.Exception ex)
        {
            print(ex.ToString());
        }
         
    }

}
