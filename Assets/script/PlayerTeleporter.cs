using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    private GameObject currentTeleporter;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
           
            if(currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleportando>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         Debug.Log("Pressione Q Para entrar no Banker");
        if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
