﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject particleFX;

    private void OnTriggerEnter2D(Collider2D collision)
        {
        Debug.Log("it worked");
        Instantiate(particleFX, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
