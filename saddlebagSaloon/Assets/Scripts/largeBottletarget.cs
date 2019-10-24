using UnityEngine;

public class largeBottletarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    Rigidbody rb;
    public AudioClip BreakingGlass;
    public AudioSource MusicSource;
    public Component MeshRender;
    public void Start()
    {
        MusicSource.clip = BreakingGlass;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 7f), ForceMode.Impulse);
    }

    public void Update()
    {
        Destroy(gameObject, timeBDestroy);
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
    {   ScoreScript.scoreValue += 5;
        MusicSource.Play();
        Destroy(MeshRender);
        Destroy(gameObject, 1f);
        
    }
}
