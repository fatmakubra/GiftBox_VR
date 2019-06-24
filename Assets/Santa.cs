using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Santa : MonoBehaviour
{
    public float speed = 3.5f;
    public float throwingForce = 300f;
    public GameObject giftPrefab;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make santa move
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space"))
        {
           GameObject giftObject = Instantiate(giftPrefab);
            giftObject.transform.position = this.transform.position;
            giftObject.GetComponent<Rigidbody> ().AddForce(this.transform.forward * throwingForce);

            Gift gift = giftObject.GetComponent<Gift> ();
            gift.onHitHouse = () =>
            {
                score += 100;
            };
        }
    }
}
