using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float horizontalNegative = 0f;
    bool salto = false;

    public static bool muerteTiempo = false;

    public bool drvita = false;
    public bool cambio = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
        horizontalNegative = Input.GetAxisRaw("Horizontal")*-1 * runSpeed;

        if (Input.GetButtonDown("Jump")) {

            salto = true;

        }

        if (muerteTiempo) {
            Muerte();
            muerteTiempo = false;
        }

        /*if (cambio == false) {

        }*/
    }

    void FixedUpdate(){
        if (drvita == true) {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, salto);
            salto = false;

        }
        else {
            controller.Move(horizontalNegative * Time.fixedDeltaTime, false, salto);
            salto = false;
        }
        
    }
    
    void Awake(){
        InvokeRepeating("Transformacion", 0, 5);
    }

    void Transformacion() {
        drvita = !drvita;
    }

    void Muerte() {

        if (drvita) {
            SceneManager.LoadScene("m_vita");
        }
        else {
            SceneManager.LoadScene("m_caedes");
        }

    }

    
}
