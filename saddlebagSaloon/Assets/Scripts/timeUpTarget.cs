using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUpTarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    public float speedR;
    public float timeAdd;
    public AudioClip RipCard;
    public AudioSource MusicSource;
    public GameObject particleEffect;
    public GameObject scorePopUp;
    Rigidbody rb;


    void Start()
    {
        MusicSource.clip = RipCard;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 5f), ForceMode.Impulse);
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
        GameTimer.currentTime = GameTimer.currentTime + timeAdd;
        MusicSource.Play();
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Instantiate(scorePopUp, transform.position, Quaternion.identity);
        Destroy(gameObject);   
    }
}
