using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class separador : MonoBehaviour
{
    public float coordenadaX;
    public float coordenadaY;
    //public Scene escena_act;
    //string nombreEscena;

    public GameObject player;

    void Start()
    {
        //escena_act = SceneManager.GetActiveScene();
        //nombreEscena = escena_act.name;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

       player.transform.position = new Vector3(coordenadaX, coordenadaY,0);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
