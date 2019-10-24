using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    Rigidbody rb;
    public AudioClip GlassBreaking;
    public AudioSource MusicSource;
    public Component MeshRender;

    void Start()
    {
        MusicSource.clip = GlassBreaking;
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
    }
    
    void Die()
    {
        MusicSource.Play();
        Destroy(gameObject, 1f);
        ScoreScript.scoreValue += 10;
    }
}
