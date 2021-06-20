using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;


    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if(hitPoints <= damage)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
