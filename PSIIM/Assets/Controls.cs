using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Controls : MonoBehaviour
    {
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpheight;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
        }

        if (jump)
        {
            Animator animator =
                    GetComponent<Animator>();
            if (onGround)
            {
                
                animator.SetBool("Jump", jump);
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
                
            }
            jump = false;
            animator.SetBool("Jump", jump);
        }

        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        Animator animator1 =
                    GetComponent<Animator>();
        

    }
}


