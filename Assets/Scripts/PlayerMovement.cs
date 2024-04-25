using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;
    public bool isJumping=false;
    public bool isGrounded;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    

    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private Vector3 velocity = Vector3.zero;

    public AudioSource audioSource;
    public AudioClip sound;


    void Update()
    {
        
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);
      
        if (Input.GetButtonDown("Jump") && isGrounded==true)
        {
            isJumping = true;
        }
        animator.SetBool("jump", isGrounded);

    }

    void FixedUpdate()
    {

        float horizontalMov = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        MovePlayer(horizontalMov);

        Flip(rb.velocity.x);

        float characterVelocity = Mathf.Abs(rb.velocity.x);

        animator.SetFloat("speed", characterVelocity);

    }

    void MovePlayer(float _horizontalMov) 
    {

        Vector3 targetVelocity = new Vector2(_horizontalMov, rb.velocity.y);

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0.05f);

        while (isJumping == true)
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    //changer la direction du perso
    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < -0.1f) 
        {
            spriteRenderer.flipX = true;
        }
    }
}
