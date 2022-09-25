using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float horizontalNegative = 0f;
    bool salto = false;

    public static bool muerteTiempo = false;

    public bool drvita = true;
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
            muerteTiempo = false;
        }
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
}
