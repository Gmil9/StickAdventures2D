using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

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
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () {

        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, ground);

        moveInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

	}

    void Update()
    {
        if(isGrounded == true){
            extraJumps = 1;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
