using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animator;

    private bool isMoving;
    private bool isFalling;


    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetTrigger("jumpTrigger");

    }


    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveInput, 0, 0) * moveSpeed * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb2d.linearVelocityY) < 0.001f)
        {
            rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetTrigger("jumpTrigger");
        }

        else if (rb2d.linearVelocityY < 0)
        {
            isFalling = true;
        }

        if (isFalling)
        {
            animator.SetTrigger("fallTrigger");

        }

        Debug.Log(rb2d.linearVelocityY);
        animator.SetInteger("Move", (int)moveInput);
    }
}
