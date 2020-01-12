using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doggoScript : MonoBehaviour
{

    private Animator animator;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {

        Vector2 velocity = rb.velocity;
        rb.velocity = velocity;

    }



}
