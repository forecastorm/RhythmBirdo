using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestroyer : MonoBehaviour
{

    public Transform target;
    public float y_offset = -10;
    public float smoothSpeed = 0.125f;
    public GameObject birdo;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (target.position.y > (transform.position.y-y_offset))
        {

            Vector3 newPos = new Vector3(target.position.x, target.position.y+y_offset, target.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name =="Birdo")
        {

            FindObjectOfType<player>().setDead();

        }

    }



}
