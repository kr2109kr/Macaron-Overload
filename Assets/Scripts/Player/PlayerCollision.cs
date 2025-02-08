using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private float movespeed;

    
    public void KnockBack()
    {
        transform.position = new Vector3(-(GetComponent<PlayerMovement>().MoveInput), 0, 0) * movespeed * Time.deltaTime;
    }


    private IEnumerator IKnockback()
    {
        while (true)
        {
            transform.position = new Vector3(-(GetComponent<PlayerMovement>().MoveInput), 0, 0) * movespeed * Time.deltaTime;

        }

        yield return null;
    }
}
