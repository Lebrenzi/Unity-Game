﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour
{

    private Controls player;
    public AudioSource bling;

    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {

            bling.Play();
            Destroy(gameObject);
            
            player.crystals++;
        
    }
}
