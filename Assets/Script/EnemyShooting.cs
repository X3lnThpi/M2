using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    float coolDownTimer = 0;
    public float fireDelay = 0.50f;



    // Update is called once per frame
    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if (coolDownTimer <= 0)
        {
            //Shoot
            coolDownTimer = fireDelay;
            Debug.Log("EnemyShhot");

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = gameObject.layer;

        }
    }
}
