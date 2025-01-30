using UnityEngine;

public class ItemHealthPack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHitPoints>().TakeHealth();
            Destroy(gameObject);
        }
    }
}
