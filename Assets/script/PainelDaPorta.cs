using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelDaPorta : MoverPortaComChave
{
    

    public static bool JogadorTemChave = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(JogadorTemChave == true && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Você abriu aporta");
            Destroy(GameObject.Find("Porta"));
            JogadorTemChave = false;
        }
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && JogadorTemChave == false)
        {
            Debug.Log("Você precisa pegar a chave para abrir a porta");
            
        }
        if(collision.CompareTag("Player") && JogadorTemChave == true)
        {    
            Debug.Log("Pressione F para abrir a porta");
        }
    }
    
    

}
