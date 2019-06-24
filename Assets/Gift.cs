﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class Gift : MonoBehaviour
{
    public Action onHitHouse;
    public GameObject[] models; 

    void Start()
    {
        int randomIndex = Random.Range(0, models.Length);
        for(int i=0; i<models.Length; i++)
        {
            models[i].SetActive(i == randomIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "GiftTarget")
        {
            Destroy (gameObject);
            Destroy (collider.gameObject);
            
            if(onHitHouse != null)
            {
                onHitHouse();
            }
        }
    }
}
