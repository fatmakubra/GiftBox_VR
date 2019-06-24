using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public GameObject[] models;

    // Start is called before the first frame update
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
}
