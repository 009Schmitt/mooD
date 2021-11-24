using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Transform staminaBar;
    public CharacterController playerCC;

    public float moveSpeed, gravityForce, sprintModifier, stamina;

    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundRadius;

    public float jumpHeight, staminaRechargeCooldown;

    private Vector3 velocity;
    private bool isGrounded;
    private float actualTime;

    // Start is called before the first frame update
    void Start()
    {
        stamina = 100;
        actualTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //staminaBar.position = new Vector3(-5 + (stamina/50),1.5f,3.0f);

        staminaBar.localScale = new Vector3((stamina / 50), 0.05f, 0.01f);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravityForce);
        }


        Vector3 move = transform.right * x + transform.forward * z;


        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0 && (move.z != 0 || move.x != 0))
        {
            //print(move);
            actualTime = Time.time + staminaRechargeCooldown;
            stamina--;
            playerCC.Move(move * (moveSpeed * sprintModifier) * Time.deltaTime);
        }
        else
        {
            playerCC.Move(move * moveSpeed * Time.deltaTime);
        }

        if(actualTime < Time.time && stamina < 100)
        {
            stamina += 2;
            if (stamina > 100)
            {
                stamina = 100;
            }
        }
        

        velocity.y += gravityForce * Time.deltaTime;

        playerCC.Move(velocity * Time.deltaTime);
    }
}
