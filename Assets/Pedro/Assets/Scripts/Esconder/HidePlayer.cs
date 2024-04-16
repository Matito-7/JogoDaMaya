using UnityEngine;
using UnityEngine.UI;

public class HidePlayer : MonoBehaviour
{
    public GameObject player; 
    public Transform hidingSpot;
    public Button hideButton;
    public Canvas interactCanvas;

    private bool isHidden; 
    private bool isPlayerHide;
   
    
    void Start()
    {
        //hideButton.interactable = false;
        interactCanvas.gameObject.SetActive(false);
    }
    void Update()
    {
        //Esconder e Aparecer 
        if (Input.GetKeyDown(KeyCode.E) && isHidden)
        {
            //_pause.PauseScreen(true);
            ShowPlayer();
        }
        if (isPlayerHide && Input.GetKeyDown(KeyCode.E))
        {
            //_pause.PauseScreen(false);
            OnHidePlayer();
        }
        //if (Input.GetButtonDown("Cancel"))
        //{
        //    _pause.PauseScreen(true);
        //}
    }

    public void OnHidePlayer()
    {
        if (isHidden)
        {
            ShowPlayer();
        }
        else
        {
            HidePlaye();
        }
    }

    void ShowPlayer()
    {
        player.SetActive(true);
        isHidden = false;
        
    }
    void HidePlaye()
    {
        // Mova o jogador para a posição de esconderijo dentro da caixa
        // Desative o jogador para evitar que ele seja controlado enquanto está escondido
        // Atualize a flag de esconderijo
        player.transform.position = hidingSpot.position;       
        player.SetActive(false);
        isHidden = true;
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isPlayerHide = true;
            interactCanvas.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isPlayerHide = false;
            interactCanvas.gameObject.SetActive(false);
        }
    }
}
