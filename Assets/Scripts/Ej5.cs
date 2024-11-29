using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(transform.forward * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(-transform.forward * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(transform.right * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-transform.right * Time.deltaTime);
        }
        
    }
}
