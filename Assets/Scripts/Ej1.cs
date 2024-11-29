using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    private Vector3 posInicial;
    
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime,0,0); // time.dt * 1 -> 1 unidad por segundo
        if (transform.position.x > 10)
        {
            transform.position = posInicial;
        }
    }
}
