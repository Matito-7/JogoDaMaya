using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public float JumpForce;
    public int life;
    public bool grounded;
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
}


