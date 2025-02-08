using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerHitPoints : MonoBehaviour
{
    [SerializeField, Range(1, 3)] private int hitPoints;
    [SerializeField] List<Image> images; 


    public void TakeHealth()
    {
        hitPoints++;
    }


    public void TakeDamage(int damage)
    {
        images[hitPoints - 1].gameObject.SetActive(false);
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            GameManager.gameManager.GameOver();
        }
    }
}
