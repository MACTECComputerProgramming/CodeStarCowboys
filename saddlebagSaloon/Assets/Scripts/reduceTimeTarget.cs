using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reduceTimeTarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    public float timeSub;
    public float speedR;
    public AudioClip ChickenCluck;
    public AudioSource MusicScource;
    public GameObject particleEffect;
    public GameObject scorePopUP;
    Rigidbody rb;

    void Start()
    {
        MusicScource.clip = ChickenCluck;
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
            ScoreScript.scoreValue -= 10;
            GameTimer.currentTime = GameTimer.currentTime -= timeSub;
            MusicScource.Play();
            Instantiate(particleEffect, transform.position, Quaternion.identity);
            Instantiate(scorePopUP, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }


}
