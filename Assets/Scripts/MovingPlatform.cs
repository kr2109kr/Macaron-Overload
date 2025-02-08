using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform waypoint_A;
    [SerializeField] private Transform waypoint_B;
    [SerializeField] private float moveSpeed;

    private bool moveToPointA;
    private bool moveToPointB;

    private void Update()
    {
        if (!moveToPointA)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_A.localPosition, 0.01f * moveSpeed);

            if (transform.localPosition == waypoint_A.localPosition)
            {
                moveToPointA = true;
                moveToPointB = false;
            }
        }


        else if (!moveToPointB)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_B.localPosition, 0.01f * moveSpeed);

            if (transform.localPosition == waypoint_B.localPosition)
            {
                moveToPointA = false;
                moveToPointB = true;
            }
        }
    }
}
