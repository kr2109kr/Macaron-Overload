using UnityEngine;

public class PlayerHitPoints : MonoBehaviour
{
    [SerializeField, Range(1, 3)]private int hitPoints;


    public void TakeHealth()
    {
        hitPoints++;
    }


    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
    }
}
