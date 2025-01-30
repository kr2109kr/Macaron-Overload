using UnityEngine;

public class ItemDoorKey : MonoBehaviour
{
    [SerializeField] private string doorKeyCode;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerCollectItem>().AddKey(doorKeyCode);
            Destroy(gameObject);
        }
    }
}
