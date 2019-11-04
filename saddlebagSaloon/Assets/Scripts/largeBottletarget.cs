using UnityEngine;

public class largeBottletarget : MonoBehaviour
{

<<<<<<< HEAD
    public float health = 1f;
    Rigidbody rb;
    public float startForce = 15f;
=======
    public float health;
    public float timeBDestroy;
    public AudioClip BreakingGlass;
    public AudioSource MusicSource;
    public GameObject particleEffect;
    public Component MeshRender;
    Rigidbody rb;

>>>>>>> Andrew-Payne

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startForce, ForceMode.Impulse);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
<<<<<<< HEAD
        Destroy(gameObject);
=======
        ScoreScript.scoreValue += 5;
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        MusicSource.Play();
        Destroy(MeshRender);
        Destroy(gameObject, 1f);
>>>>>>> Andrew-Payne
    }
}
