using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;       
    [SerializeField] Joystick joyStick;
    [SerializeField] bool isJumping;
    [SerializeField] float jumpForce;

    Rigidbody2D rb;
    Animator animator;
    bool facingRight = true;
    AudioSource audioSource;

    private void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMove = joyStick.Horizontal;
        rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if(!facingRight && horizontalMove > 0) { Flip(); }
        else if(facingRight && horizontalMove < 0) { Flip(); }
    }


    public void Jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            if (isJumping)
            {
                animator.SetBool("isJumping", true);
            }
        }
        audioSource.PlayOneShot(AudioManager.Instance.jumpSound);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            animator.SetBool("isJumping", false);
        }

        if (col.gameObject.CompareTag("MovingPlatform"))
        {
            isJumping = false;
            gameObject.transform.parent = col.gameObject.transform;
            animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("MovingPlatform"))
        {
            gameObject.transform.parent = null;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
