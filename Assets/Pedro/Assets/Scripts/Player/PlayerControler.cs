using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControler : MonoBehaviour
{
    private Rigidbody2D rb;
    private CapsuleCollider2D cc2d;
    public GameObject gameOver;
    private Animator anim;


    public float speed;
    private float moveX;
    public int life;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc2d = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");

        if (life <= 0)
        {
            this.enabled = false;
            gameOver.SetActive(true);
        }

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        if (moveX >0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            anim.SetBool("isWalk", true);
        }

        if (moveX <0)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            anim.SetBool("isWalk", true);
        }

        if (moveX == 0)
        {
            anim.SetBool("isWalk", false);
        }
    }
}
