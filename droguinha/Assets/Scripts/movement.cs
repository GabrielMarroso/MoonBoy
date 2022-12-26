using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public Animator animator;

    public float runSpeed = 10f;
    public float jumpSpeed = 150f;

    public bool canJump = true;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground" )
        {
            animator.SetBool("InAir", false);

            canJump = true;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            animator.SetBool("InAir", true);
            canJump = false;
        }
    }

    void Update()
    {


        if (Input.touchCount > 0 && canJump == true)
        {

                       rb2d.AddForce(Vector2.up * jumpSpeed);

        }
      //  else
       // {     rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);}
    }


}
