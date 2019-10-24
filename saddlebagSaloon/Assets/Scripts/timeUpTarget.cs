using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUpTarget : MonoBehaviour
{

    public float health = 1f;
    Rigidbody rb;
    public float timeBDestroy = 2f;
    public float speedR;
    public float timeAdd;
    

    

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 7f), ForceMode.Impulse);
        transform.Rotate(90, 180, 0);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * speedR * Time.deltaTime);
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

        GameTimer.currentTime = GameTimer.currentTime + timeAdd;
    }
}
