using UnityEngine;

public class PlayerHitPoints : MonoBehaviour
{
    private int hitPoints;

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
    }
}
