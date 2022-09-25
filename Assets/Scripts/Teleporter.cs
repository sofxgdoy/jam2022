using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destino;
    
    public Transform GetDestino() 
    {
        return destino;
    }
}
