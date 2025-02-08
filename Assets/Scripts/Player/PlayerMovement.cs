using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animator;

    private bool isMoving;
    private bool isFalling;
    private bool isFacingRight = true;
    public bool isKnockback;
    public bool knockFormRight;

    public float MoveInput { get; private set; }
    private float moveSpeedSave;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float knockbackForce;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetTrigger("jumpTrigger");

        moveSpeedSave = moveSpeed;
    }


    private void Update()
    {
        MoveInput = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(MoveInput, 0, 0) * moveSpeed * Time.deltaTime;


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


        if (!isFacingRight && MoveInput > 0)
        {
            Flip();
        }

        else if (isFacingRight && MoveInput < 0)
        {
            Flip();
        }


        if (isKnockback)
        {
            if (knockFormRight)
            {
                rb2d.linearVelocity = new Vector2(-knockbackForce * 2, knockbackForce);
            }

            else
            {
                rb2d.linearVelocity = new Vector2(knockbackForce * 2, knockbackForce);
            }

            moveSpeed = 0;
            
            Invoke("CancleKnockback", 0.1f);
            Invoke("ResetMoveSpeed", 0.5f);
        }


        Debug.Log(rb2d.linearVelocityY);
        animator.SetInteger("Move", (int)MoveInput);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    private void CancleKnockback()
    {
        isKnockback = false;
    }

    private void ResetMoveSpeed()
    {
        moveSpeed = moveSpeedSave;
    }

}
