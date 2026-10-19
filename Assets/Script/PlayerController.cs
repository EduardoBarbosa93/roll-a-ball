using System;
using TMPro; // NOVO: para usar textos
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    public TextMeshProUGUI countText; // NOVO: texto dos 
    public GameObject winTextObject; // NOVO: texto de vitória
    public GameObject loseTextObject;
    public GameObject ColeteOsGatinhosObject;
    private Rigidbody rb;
    private int count; // NOVO: contador de pontos
    void Start()

    {
        transform.position = new Vector3(-10, 3f, -75);
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false); // NOVO: esconde "Você venceu!"
        loseTextObject.SetActive(false); // esconde "Você perdeu!!"
        ColeteOsGatinhosObject.SetActive(true); // mostra "Colete os gatinhos!"

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    // NOVO: chamado quando a bola entra em um Trigger
        void OnTriggerEnter(Collider other)
          {

                // Só coleta se o objeto tiver a Tag "PickUp" ou "PickUp SuperCat"
                   if (other.gameObject.CompareTag("PickUp"))
                   {
                         other.gameObject.SetActive(false); // Some o item depois de coletado
                         count += 1;   // Soma um ponto ao coletá-lo
                         SetCountText();
                   }
                   else if (other.gameObject.CompareTag("PickUp SuperCat")) 
                   {

                     other.gameObject.SetActive(false);
                     count += 3;
                     SetCountText();
                   }

                   if (other.gameObject.CompareTag("EvilEnemy"))
                   {
                      Destroy(gameObject);
                      loseTextObject.SetActive(true);
                   }
               
          }
    // NOVO: atualiza o texto e verifica a vitória
    void SetCountText()
    {
        countText.text = "Gatinhos: " + count.ToString();

        if(count >= 22)
        {
            winTextObject.SetActive(true);
            transform.position = new Vector3(0, 100, 0);
            ColeteOsGatinhosObject.SetActive(false);
           

        }
    }
}