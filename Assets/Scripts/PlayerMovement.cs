using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        jumpSound.Play();
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    } 
}



//if (Input.GetKeyDown("space"))
//{
//    rb.velocity = new Vector3(0, 5, 0);
//}

//if (Input.GetKey("up"))
//{
//    rb.velocity = new Vector3(0, 0, 4);
//}
//if (Input.GetKey("w"))
//{
//    rb.velocity = new Vector3(0, 0, 4);
//}
//if (Input.GetKey("right"))
//{
//    rb.velocity = new Vector3(2, 0, 0);
//}
//if (Input.GetKey("d"))
//{
//    rb.velocity = new Vector3(2, 0, 0);
//}
//if (Input.GetKey("left"))
//{
//    rb.velocity = new Vector3(-2, 0, 0);
//}
//if (Input.GetKey("a"))
//{
//    rb.velocity = new Vector3(-2, 0, 0);
//}
//if (Input.GetKey("down"))
//{
//    rb.velocity = new Vector3(0, 0, -2);
//}
//if (Input.GetKey("s"))
//{
//    rb.velocity = new Vector3(0, 0, -2);
//}