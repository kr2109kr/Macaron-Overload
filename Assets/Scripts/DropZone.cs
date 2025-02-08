using UnityEngine;

public class DropZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.gameManager.GameOver();
        }
    }
}
