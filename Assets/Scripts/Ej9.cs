using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ej9 : MonoBehaviour
{
    private float timer = 3f;
    private bool countdown = false;
    
    private void OnMouseDown()
    {
        if (!countdown)
        {
            timer = Random.Range(3f, 5f);
            countdown = true;
        }
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