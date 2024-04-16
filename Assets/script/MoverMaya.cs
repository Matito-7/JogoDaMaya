using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMaya : MonoBehaviour
{
    public int life;
    public float Speed;
    public float ForcaPulo;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Jump();
    }

    void Mover()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rig.AddForce(new Vector3(0f, ForcaPulo, 0f), ForceMode2D.Impulse);
        }
    }
}
