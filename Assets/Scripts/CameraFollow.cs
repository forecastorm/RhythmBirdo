using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;


    public Vector3 offset;


    // Update is called once per frame
    //void LateUpdate()
    //{
    //    if (target.position.y > transform.position.y)
    //    {

    //        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
    //        transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
    //    }

    //}



    //void LateUpdate()
    //{

    //        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
    //        transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        

    //}

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }




}
