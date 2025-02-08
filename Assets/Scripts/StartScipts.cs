using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScipts : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
