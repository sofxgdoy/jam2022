using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject TeleportActual; //va a tomar en que teleport nos encontramos
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            if (TeleportActual != null)
            {
                transform.position = TeleportActual.GetComponent<Teleporter>().GetDestino().position;
            }

        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter")) {

            TeleportActual = collision.gameObject;

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter")) {
            if (collision.gameObject == TeleportActual)
            {
                TeleportActual = null;
            }

        }
        
    }
}
