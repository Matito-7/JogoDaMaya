using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoldierKitten : MonoBehaviour
{
    public Transform soldier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<MoverMaya>().life--;
    }
}
