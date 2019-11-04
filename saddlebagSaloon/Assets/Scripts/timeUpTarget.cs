using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUpTarget : MonoBehaviour
{

<<<<<<< HEAD
    public float health = 1f;
    Rigidbody rb;
    public float startingForce = 15;
    public float timeBDestroy = 2f;
    public float speedR;
    public float timeAdd;
    
=======
    public float health;
    public float timeBDestroy;
    public float speedR;
    public float timeAdd;
    public AudioClip RipCard;
    public AudioSource MusicSource;
    public GameObject particleEffect;
    public Component MeshRender;
    Rigidbody rb;
>>>>>>> Andrew-Payne

    

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startingForce, ForceMode.Impulse);
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
<<<<<<< HEAD
        
        Destroy(gameObject);

        GameTimer.currentTime = GameTimer.currentTime + timeAdd;
=======
        GameTimer.currentTime = GameTimer.currentTime + timeAdd;
        MusicSource.Play();
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(MeshRender);
        Destroy(gameObject, 1f);   
>>>>>>> Andrew-Payne
    }
}
