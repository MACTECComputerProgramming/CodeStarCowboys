using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUpTarget : MonoBehaviour
{

    public float health = 1f;
    Rigidbody rb;
    public float startingForce = 15;
    public float timeBDestroy = 2f;
    
    public float timeAdd;
    public GameObject timeTarget;

    

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startingForce, ForceMode.Impulse);
        transform.Rotate(90, 180, 0);
    }

    private void Update()
    {
        
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
        
        Destroy(gameObject, timeBDestroy);

        GameTimer.currentTime = GameTimer.currentTime + timeAdd;
    }
}
