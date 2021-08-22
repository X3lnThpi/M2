using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    float coolDownTimer = 0;
    public float fireDelay = 0.25f;
   
    // Update is called once per frame
    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && coolDownTimer <= 0 )
        {
            //Shoot
            coolDownTimer = fireDelay;
            Debug.Log("Shhot");
           
            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }
    }
}
