using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    public AudioClip GlassBreaking;
    public AudioSource MusicSource;
    public GameObject particleEffect;
    public GameObject scorePopUp;
    Rigidbody rb;
    void Start()
    {
        MusicSource.clip = GlassBreaking;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 5f), ForceMode.Impulse);
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
        ScoreScript.scoreValue += 10;
        MusicSource.Play();
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Instantiate(scorePopUp, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
