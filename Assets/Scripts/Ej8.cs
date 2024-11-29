using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    private float timer = 3f;
    private bool countdown = false;
    
    private void OnMouseDown()
    {
        countdown = true;
    }

    private void Update()
    {
        if (countdown)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}