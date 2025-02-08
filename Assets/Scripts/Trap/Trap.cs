using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.transform.position.x <= transform.position.x)
            {
                collision.GetComponent<PlayerMovement>().knockFormRight = true;
            }


            else if (collision.transform.position.x >= transform.position.x)
            {
                collision.GetComponent<PlayerMovement>().knockFormRight = false;
            }

            collision.GetComponent<PlayerMovement>().isKnockback = true;

            collision.GetComponent<PlayerHitPoints>().TakeDamage(1);
        }
    }
}
