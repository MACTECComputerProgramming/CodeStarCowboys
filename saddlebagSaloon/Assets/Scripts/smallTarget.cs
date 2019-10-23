using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTarget : MonoBehaviour
{

    public float health;
    public float startForce;
    public float timeBDestroy;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startForce, ForceMode.Impulse);
    }

    private void Update()
    {
        Destroy(gameObject, timeBDestroy);
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
        Destroy(gameObject);
    }
}
