using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
