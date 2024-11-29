using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    private Vector3 posInicial;
    //private Vector3 posFinal;
    private bool direccion = true; // positiva = true
    
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        //posFinal = new Vector3(posInicial.x + 10, posInicial.y, posInicial.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (direccion)
        {
            transform.Translate(Time.deltaTime,0,0); // time.dt * 1 -> 1 unidad por segundo
        }
        else
        {
            transform.Translate(-Time.deltaTime,0,0); // time.dt * 1 -> 1 unidad por segundo
        }
        
        if (transform.position.x > 10)
        {
            direccion = false;
        } else if (transform.position.x < 0)
        {
            direccion = true;
        }
    }
}