using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUpTarget : MonoBehaviour
{

    public float health = 1f;
    Rigidbody rb;
    public float startingForce = 15;
    public float timeBDestroy = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startingForce, ForceMode.Impulse);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }
    
    void Die()
    {
        GameTimer gt = new GameTimer();
        Destroy(gameObject);
        int newCurrentTime = (int)gt.currentTime + 5;
        
    }
}
