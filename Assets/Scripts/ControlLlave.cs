using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLlave : MonoBehaviour
{
    public bool RecogioLlave; 
    public GameObject msj;
    // Start is called before the first frame update
    void OnTriggerEnter2D() {
        gameObject.SetActive(false);

        msj.gameObject.SetActive(false);

        RecogerLlave();
    }

    void RecogerLlave() {
        RecogioLlave = true;
    }
}
