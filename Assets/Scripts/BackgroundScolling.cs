using UnityEngine;
using UnityEngine.UI;

public class ScrollingBG : MonoBehaviour
{
    private Material material;
    private float distance;
    [SerializeField] private float moveSpeed;
    [SerializeField] private PlayerMovement playerMovement;


    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }


    private void Update()
    {
        //distance += Time.deltaTime * 2f;
        material.mainTextureOffset += Vector2.right * moveSpeed * playerMovement.MoveInput * 0.1f;
    }
}
