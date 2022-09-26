using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{
    public CharacterController2D controller;
    
    //Animator animator = gameObject.GetComponent<Animator>();
    //public Animator animator;
    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float horizontalNegative = 0f;
    bool salto = false;

    private Animator anim;
    private Rigidbody2D rb;

    public static bool muerteTiempo = false;

    public bool drvita = false;
    public bool cambio = false;
    
    //private shake shake;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        //shake = GameObject.FindGameObjectsWithTag("ScreenShake").GetComponent<Shake>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
        horizontalNegative = Input.GetAxisRaw("Horizontal")*-1 * runSpeed;


        if (muerteTiempo) {
            Muerte();
            muerteTiempo = false;
        }


    }

    void FixedUpdate(){
        if (drvita == true) {
            if (Input.GetButtonDown("Jump")) {
            salto = true;
            anim.SetBool("Jump", true);
        }
            else{
                anim.SetBool("Jump", false);
            }

            controller.Move(horizontalMove * Time.fixedDeltaTime, false, salto);
            salto = false;
            
            if (horizontalMove == 0){
                anim.SetBool("Move", false);
            }
            else{
                anim.SetBool("Move", true);
            }
          
        }
        //Caede
        else {
            if (Input.GetButtonDown("Jump")) {
            salto = true;
            anim.SetBool("Jump", true);
        }
            else{
                anim.SetBool("Jump", false);
            }
            controller.Move(horizontalNegative * Time.fixedDeltaTime, false, salto);
            salto = false;

            if (horizontalMove == 0){
                anim.SetBool("Move", false);
            }
            else{
                anim.SetBool("Move", true);
            }

        }

        
    }
    
    void Awake(){
        InvokeRepeating("Transformacion", 0, 5);
    }

    void Transformacion() {
        //set.trigger("pedos", true);
        drvita = !drvita;
        //animator.Play("CameraShake");
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
