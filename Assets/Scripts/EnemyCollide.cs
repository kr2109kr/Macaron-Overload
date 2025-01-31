using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHitPoints>().TakeDamage(1);
        }
    }
}
