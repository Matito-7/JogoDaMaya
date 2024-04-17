using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;
    public LayerMask PlayerLayer;
    public float radious;

    private DialogueControl dc;
    bool onradious;
     void Start()
    {
        dc = FindObjectOfType<DialogueControl>();

    }
            
    private void FixedUpdate()
    {
        Interact();
    }
        
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onradious)
        {
            dc.Speech(profile, speechTxt, actorName);
        }
    }
    

    public void Interact()
    {

        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, PlayerLayer);
        if (hit != null)
        {
            onradious = true;

        }
        else
        {
            onradious = false;
        }
    }
} 
