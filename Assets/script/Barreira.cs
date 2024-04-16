using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreira : MonoBehaviour
{
    public Transform[] pos;
    public float velocidade = 2f;
    public GameObject porta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       AbrirPorta();
    }

    void AbrirPorta()
    {
        
         if(botao.Pisou == true && porta.gameObject.transform.position.y <= pos[0].position.y)
        {
            transform.Translate(Vector2.up * Time.deltaTime * velocidade);
        }
        else if(botao.Pisou == false && porta.gameObject.transform.position.y >= pos[1].position.y)
        {
            transform.Translate(Vector2.down * Time.deltaTime * velocidade);
        }
    }
}
