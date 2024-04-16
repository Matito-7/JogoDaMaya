using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botao : MonoBehaviour
{
    public static bool Pisou;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Caixa")
        {
            Pisou = true;
            Debug.Log("Pisou");
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Caixa")
        {
            Pisou = false;
            Debug.Log("Saiu");
        }
    }
    
}
