using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankactive : MonoBehaviour
{
    public GameObject tank;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            tank.SetActive(true);
        }

        if (tank)
        {
            Destroy(this.gameObject);
        }
    }
}
