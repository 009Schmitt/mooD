using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerCC;
    
    public float moveSpeed,gravityForce;

    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundRadius;

    public float jumpHeight;

    private Vector3 velocity;
    private bool isGrounded;
    private float actualSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundMask);
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravityForce);
        }


        Vector3 move = transform.right * x + transform.forward * z;

        playerCC.Move(move * moveSpeed * Time.deltaTime);

        velocity.y += gravityForce * Time.deltaTime;

        playerCC.Move(velocity * Time.deltaTime); 
    }
}
