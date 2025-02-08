using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }

        else
        {
            gameManager = this;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
