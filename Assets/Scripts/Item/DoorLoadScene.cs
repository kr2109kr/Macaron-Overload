using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoadScene : MonoBehaviour
{
    [SerializeField] private Object scene;
    [SerializeField] private string doorCode;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerCollectItem>().CheckKey(doorCode))
            {
                SceneManager.LoadScene(scene.name);
            }
        }
    }

}
