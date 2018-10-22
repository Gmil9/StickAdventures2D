using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Animator anim;
    SpriteRenderer flip;
    bool isLeft = false;

    [SerializeField] float speed;
    [SerializeField] float moveInput;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;

    bool isGrounded;
    [SerializeField] Transform GroundCheck;
    [SerializeField] float checkRadius;
    [SerializeField] LayerMask ground;

    int extraJumps = 1;

    void Start()
    {
        anim = GetComponent<Animator>();
        flip = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () {

        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, ground);

        moveInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        anim.SetFloat("Speed", moveInput * speed);
        anim.SetFloat("FallSpeed", rb.velocity.y);

        if (Input.GetKey(KeyCode.LeftArrow)){
            isLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            isLeft = false;
        }

        if (isLeft == true){
            flip.flipX = true;
        }
        else{
            flip.flipX = false;
        }
    }

    void Update()
    {
        if(isGrounded == true){
            extraJumps = 1;
            anim.SetBool("Jump", false);
        }else{
            anim.SetBool("Jump", true);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}