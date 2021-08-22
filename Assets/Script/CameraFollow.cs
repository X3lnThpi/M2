using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform myTarget;
    float maxSpeed = 3.7f;

    private void Start()
    {
        PlayerMovement playerMovement = gameObject.GetComponent<PlayerMovement>();
       // Vector3 pos = playerMovement.transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        //if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        //{
        //    pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        //    Debug.Log(pos);
        //}

        //if (myTarget != null)
        //{
        //    Vector3 targPos = myTarget.position;
        //    targPos.z = transform.position.z;
        //    transform.position = targPos;
        //}

        Vector3 pos = transform.position;
        pos.y += maxSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
