using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = defSpeed;
    public float JumpForce;
    public int life;
    public bool grounded;
    public const float runSpeed = 15;
    public const float defSpeed = 6;
    public Transform detector;
    public LayerMask ground;
   
    

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        Jump();
        Run();
    }


    void Jump()
    {
        grounded = Physics2D.OverlapCircle(detector.position, 0.1f, ground);

        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);


        }
    }

    void Walk()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

            float inputAxis = Input.GetAxis("Horizontal");

            if (inputAxis > 0)
            {
                transform.eulerAngles = new Vector2(0f, 0f);
            }

            if (inputAxis < 0)
            {
                transform.eulerAngles = new Vector2(0f, 180f);
            }
        
    }

    void Run()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
           
        }
        else
        {
            if(speed != defSpeed)
            {
                speed = defSpeed;
            }
        }
    }

    

}


