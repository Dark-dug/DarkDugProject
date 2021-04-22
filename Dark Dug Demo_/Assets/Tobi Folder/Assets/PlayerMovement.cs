using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
  
    public Animator animator;
   
    
    Vector2 movement;

    private float attackTime = .25f;
    private float attackcounter = .25f;
    private bool isAttacking;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       

  


        animator.SetFloat("moveX", movement.x);
        animator.SetFloat("moveY", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical")== -1)
        {
            animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
        if (Input.anyKey)
        {
            GetComponent<AudioSource>().UnPause();
        }
        else
        {
            GetComponent<AudioSource>().Pause();
        }

        if (isAttacking)
        {
            rb.velocity = Vector2.zero;
            attackcounter -= Time.deltaTime;
            if(attackcounter <= 0)
            {
                animator.SetBool("isAttacking", false);
                isAttacking = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackcounter = attackTime;
            animator.SetBool("isAttacking", true);
            isAttacking = true;
        }
        


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
       

    }
    

}
