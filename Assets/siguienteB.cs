using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguienteB : MonoBehaviour
{
    public GameObject mov;
    public GameObject port_llave;

    public GameObject trans;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Boton1() {
        mov.gameObject.SetActive(false);
        
        port_llave.gameObject.SetActive(true);
    }

    public void Boton2() {
        port_llave.gameObject.SetActive(false);
        trans.gameObject.SetActive(true);

    }

    
}
