using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByCollison : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 1;
    int correctlayer;

    private void Start()
    {
        correctlayer = gameObject.layer;
    }

    public float invulnperiod = 0;
    float invulnTimer = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collison Detected");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger detected");
        
            health--;
            invulnTimer = invulnperiod;

            gameObject.layer = 7;
       

       

    }

    private void Update()
    {
        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0)
        {
            gameObject.layer = correctlayer;
        }


        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
        //throw new NotImplementedException();
    }
}
