using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ControlPuerta : MonoBehaviour
{
    public ControlLlave CL;
    public Scene escena_act;
    string nombreEscena;
    public static bool nivel1 = false;

    public static bool nivel2 = false;

    private void Start(){
        escena_act = SceneManager.GetActiveScene();
        nombreEscena = escena_act.name;
    }
    

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

        if (nombreEscena == "Nivel1") {
            SceneManager.LoadScene("Nivel2");
            nivel1=true;
            
        }

        if (nombreEscena == "Nivel2" ) {
            SceneManager.LoadScene("Nivel3");
            nivel2=true;
        }

        if (nombreEscena == "Nivel3") {
            SceneManager.LoadScene("Final");
        }

        
    }

    void TeOlvidasteLlave() {
        Debug.Log("TeOlvidasteLlave");
    }
    void Update()
    {
        
    }
}
