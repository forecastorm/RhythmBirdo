using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]

public class player : MonoBehaviour
{



    public float movementSpeed = 1f;

    public float normalBounceSpeed = 13f;
    public float LongBounceSpeed = 23f;
    public float LongBounceSpeed2 = 37f;


    public float gravityScale = 1.5f;
    public float reducedGravityScale = 0.7f;
    public float zeroGravity = 0f;
    
    


    public Animator animator;

    Rigidbody2D rb;
    float movement;

    float y_movement;

    private bool facingRight = true;


    private bool isGrounded;
    private bool isBounced;


    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsBounce;


    public Joystick joystick;


    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    
        if (collision.collider.tag == "doggoTag")
        {
            setDead();
        }


        if(collision.collider.tag == "normalGroundTag")
        {
            SetNormalGravity();
        }

        

    }
    public void setDead()
    {
        isDead = true;
        animator.SetBool("isCrouching", false);
        animator.SetBool("isDead", true);
        FindObjectOfType<GameManagerScript>().EndGame();
    }



    void Update()
    {

        if (!isDead)
        {
            movement = Input.GetAxis("Horizontal") * movementSpeed;
            //y_movement = Input.GetAxis("Vertical") * movementSpeed;
            //movement = joystick.Horizontal * movementSpeed;
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
            isBounced = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsBounce);



            animator.SetFloat("speed", Mathf.Abs(movement));

            if (facingRight == false && movement > 0)
            {
                Flip();
            }
            else if (facingRight == true && movement < 0)
            {
                Flip();
            }

        }
       
    }




    // Update is called once per frame
    void FixedUpdate()
    {
       
        Vector2 velocity = rb.velocity;
        velocity.x = movement;


        //y
        //velocity.y = y_movement;

        rb.velocity = velocity;
    }

    public void BounceNormal()     
    {


        if (isGrounded)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = normalBounceSpeed;
            rb.velocity = velocity;
      
        }

        //transform.Translate(0,5f, 0);

    }


    public void BounceLong() { 


        if (isBounced)
        {
            ReduceGravity();
            Vector2 velocity = rb.velocity;
            velocity.y = LongBounceSpeed;
            rb.velocity = velocity;

        }
        else if (isGrounded && !isBounced)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = LongBounceSpeed;
            rb.velocity = velocity;
            
        }

       


    }





    private void ReduceGravity()
    {


        rb.gravityScale = reducedGravityScale;


    }

    private void SetGravityZero()
    {


        rb.gravityScale = zeroGravity;


    }


    private void SetNormalGravity()
    {
        rb.gravityScale = gravityScale;
    }



    public void turnOnCrouching()
    {
        animator.SetBool("isCrouching", true);
    }

    public void turnOffCrounching()
    {
        animator.SetBool("isCrouching", false);
    }




    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
