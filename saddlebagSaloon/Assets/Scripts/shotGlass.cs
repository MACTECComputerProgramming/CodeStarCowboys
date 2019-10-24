using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGlass : MonoBehaviour
{

    public float health;
    
    public float timeBDestroy;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 7f), ForceMode.Impulse);
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
        void Die()
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 20;
        }
    }
    
}
