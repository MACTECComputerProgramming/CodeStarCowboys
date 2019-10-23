using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGlass : MonoBehaviour
{

    public float health;
    public float startForce;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startForce, ForceMode.Impulse);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 20;
        }
    }
    
}
