using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ControlPuerta : MonoBehaviour
{
    public ControlLlave CL;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CL.RecogioLlave) 
        {
            PasarNivel();
        } else {
            TeOlvidasteLlave();
        }
    }

    void PasarNivel() {

        //SceneManager.LoadScene("Escena2");
        Debug.Log("PasarNivel");
    }

    void TeOlvidasteLlave() {
        Debug.Log("TeOlvidasteLlave");
    }
    void Update()
    {
        
    }
}
