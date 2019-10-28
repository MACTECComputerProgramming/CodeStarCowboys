using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reduceTimeTarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    public float timeSub;
    public float speedR;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 6f), ForceMode.Impulse);
    }

    void Update()
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
        void Die()
        {
            Destroy(gameObject);
            ScoreScript.scoreValue -= 10;
            GameTimer.currentTime = GameTimer.currentTime -= timeSub;
        }

    }


}
