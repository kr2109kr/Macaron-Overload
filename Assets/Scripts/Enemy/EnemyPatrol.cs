using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform waypoint_A;
    [SerializeField] private Transform waypoint_B;
    [SerializeField] private float moveSpeed;

    private bool moveToPointA;
    private bool moveToPointB;
    private bool isFacingRight;

    private void Update()
    {
        if (!moveToPointA)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_A.position, moveSpeed * Time.deltaTime);

            if (transform.localPosition == waypoint_A.position)
            {
                moveToPointA = true;
                moveToPointB = false;
                isFacingRight = true;
                Flip();
            }
        }


        else if (!moveToPointB)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_B.position, moveSpeed * Time.deltaTime);

            if (transform.localPosition == waypoint_B.position)
            {
                moveToPointA = false;
                moveToPointB = true;
                isFacingRight = false;
                Flip();
            }
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
