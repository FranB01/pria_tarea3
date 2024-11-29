using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    private float minScale = 1;
    private float scale = 1;
    private float changeSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            scale += changeSpeed * Time.deltaTime;
        } else if (scale > minScale)
        {
            scale -= changeSpeed * Time.deltaTime;
        }

        if (scale < minScale) scale = minScale;
        
        transform.localScale = new Vector3(scale,scale,scale);
    }
}
