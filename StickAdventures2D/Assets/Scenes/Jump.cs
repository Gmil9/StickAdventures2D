using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [SerializeField] float fallMult = 2.5f;
    [SerializeField] float lowjumpMult = 2f;
    [SerializeField] float jumpVelocity = 5f;

    Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if(Input.GetButtonDown("Jump")){
            rb.velocity = Vector2.up * jumpVelocity;
        }

        if(rb.velocity.y < 0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMult - 1) * Time.deltaTime;
        }else if(rb.velocity.y > 0 && !Input.GetButton("Jump")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpMult - 1) * Time.deltaTime;
        }
	}
}
