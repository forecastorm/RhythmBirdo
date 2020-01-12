using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDoggoScript : MonoBehaviour

{


    public float chase_speed_x;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void AllDoggoChase()
    {


        GameObject[] doggos;
        doggos = GameObject.FindGameObjectsWithTag("doggoTag");

        Animator animator;
        Vector2 velocity;


        //Vector3 Scaler;


        foreach (GameObject doggo in doggos)
        {
            animator = doggo.GetComponent<Animator>();
            animator.SetBool("isChasing", true);
            velocity = doggo.GetComponent<Rigidbody2D>().velocity;

            
            //Scaler = doggo.GetComponent<Transform>().localScale;
            //Scaler.x *= -1;
            //doggo.GetComponent<Transform>().localScale = Scaler;

            if (doggo.GetComponent<Rigidbody2D>().transform.rotation.eulerAngles.y == 180)
            {
                velocity.x = -chase_speed_x;
            }
            else
            {
                velocity.x = chase_speed_x;
            }
           
            doggo.GetComponent<Rigidbody2D>().velocity = velocity;

        }
    }


    public void AllDoggoBack()
    {
        GameObject[] doggos;
        doggos = GameObject.FindGameObjectsWithTag("doggoTag");

      
        Vector2 velocity;

        Vector3 Scaler;

        foreach (GameObject doggo in doggos)
        {

            Scaler = doggo.GetComponent<Transform>().localScale;
            Scaler.x *= -1;
            doggo.GetComponent<Transform>().localScale = Scaler;

            velocity = doggo.GetComponent<Rigidbody2D>().velocity;


            if (doggo.GetComponent<Rigidbody2D>().transform.rotation.eulerAngles.y == 180)
            {
                velocity.x = chase_speed_x;
            }
            else
            {
                velocity.x = -chase_speed_x;
            }

            doggo.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }



    public void AllDoggoIdel()
    {

        GameObject[] doggos;
        doggos = GameObject.FindGameObjectsWithTag("doggoTag");

        Animator animator;
       

        foreach (GameObject doggo in doggos)
        {

            animator = doggo.GetComponent<Animator>();
            animator.SetBool("isChasing", false);
        }


    }


    public void AllDoggoJump()
    {

        GameObject[] doggos;
        doggos = GameObject.FindGameObjectsWithTag("doggoTag");

        Animator animator;
       

        foreach (GameObject doggo in doggos)
        {

            animator = doggo.GetComponent<Animator>();
            animator.SetBool("isJumping", true);


        }


    }


    public void AllDoggoStopJump()
    {

        GameObject[] doggos;
        doggos = GameObject.FindGameObjectsWithTag("doggoTag");

        Animator animator;


        foreach (GameObject doggo in doggos)
        {

            animator = doggo.GetComponent<Animator>();
            animator.SetBool("isJumping", false);


        }


    }



}

