using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public bool isStandingStill = true;
    //public Animator animator;
   // public bool isFacingRight = true;
    public string[] faveCandies;
    public string[] collectedCandies;

    void Start(){
       // animator = GetComponent<Animator>();
    }

    void processInputs(){
      float moveX = Input.GetAxisRaw("Horizontal");
      moveDirection = new Vector2(moveX,0);
      if (moveDirection != Vector2.zero){
        transform.right = moveDirection;
       // animator.setBool("isMoving",true);
      }
    }

    void move(){
        rb.velocity = new Vector2(moveDirection.x*speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
    }

    void FixedUpdate(){
        move();
    }
}
