using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownTarget : MonoBehaviour
{

    public float health;
    public float startforce;
    public float timeBDestroy;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startforce, ForceMode.Impulse);
        transform.Rotate(90, 180, 0);
    }

    private void Update()
    {
        Destroy(gameObject, timeBDestroy);   
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        ScoreScript.scoreValue += 10;
    }
}
