using UnityEngine;
using UnityEngine.Scripting;



public class largeBottletarget : MonoBehaviour
{
      

    public float health;
    public float timeBDestroy;
    public float largeBottlePoints;
    public AudioClip BreakingGlass;
    public AudioSource MusicSource;
    public GameObject particleEffect;
    public Component MeshRender;
    Rigidbody rb;


    public void Start()
    {
        MusicSource.clip = BreakingGlass;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * Random.Range(3f, 5f), ForceMode.Impulse);
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
    {

        
        ScoreScript.scoreValue += ScoreScript.addUp(largeBottlePoints);
        ScoreScript.scoreValue += 5;
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        MusicSource.Play();
        Destroy(MeshRender);
        Destroy(gameObject, 1f);
        

    }
}
