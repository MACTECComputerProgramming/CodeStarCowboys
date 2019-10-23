using UnityEngine;

public class largeBottletarget : MonoBehaviour
{
    public AudioClip BreakingGlass;
    public AudioSource MusicSource;
    public Component MeshRender;
    public float health = 1f;
    Rigidbody rb;
    public float startForce = 15f;

    public void Start()
    {
        MusicSource.clip = BreakingGlass;

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * startForce, ForceMode.Impulse);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0f)
        {
            Die();
            MusicSource.Play();

            
            
        }
    }

    void Die()
    {   
        Destroy(MeshRender);
        Destroy(gameObject, 1f);
    }
}
