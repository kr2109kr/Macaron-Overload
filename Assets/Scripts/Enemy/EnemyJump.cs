using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] float jumpForce;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2d.AddForce(new Vector2(rb2d.linearVelocityX, jumpForce));
    }
}
