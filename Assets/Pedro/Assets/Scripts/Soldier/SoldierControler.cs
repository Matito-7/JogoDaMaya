using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierControler : MonoBehaviour
{
    //private CapsuleCollider2D colliderSoldier;
    //private Animator anim;
    private bool goRight;
    public float speed;

    public Transform a;
    public Transform b;
    void Start()
    {

    }


    void Update()
    {
        if (goRight == true)
        {
            if (Vector2.Distance(transform.position, b.position) < 0.1f)
            {
                goRight = false;
            }
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            transform.position = Vector2.MoveTowards(transform.position, b.position, speed * Time.deltaTime);
        }

        else
        {
            if (Vector2.Distance(transform.position, a.position) < 0.1f)
            {
                goRight = true;
            }
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            transform.position = Vector2.MoveTowards(transform.position, a.position, speed * Time.deltaTime);
        }
    }
}
