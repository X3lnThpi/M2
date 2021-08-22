using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float maxSpeed = 3.5f;
    float sideMove = 3f;
    float shipBoundaryRadius = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Roate the Ship
        //Quaternion rot = transform.r
        
        //Move the Ship
        Vector3 pos = transform.position;
        // pos.y += Input.GetAxis("Vertical");
        pos.y +=  maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * sideMove * Time.deltaTime;
       // pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        if(Input.GetAxis("Vertical") < 0)
        {
            pos.y += Input.GetAxis("Vertical") * (-1) * Time.deltaTime;
        }
        transform.position = pos;

        //Restrict Player to camera boundry
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
           // Debug.Log(pos);
        }

        
        
    }
}
