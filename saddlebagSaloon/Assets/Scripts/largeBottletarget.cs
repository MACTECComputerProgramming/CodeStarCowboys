using UnityEngine;
using UnityEngine.Scripting;



public class largeBottletarget : MonoBehaviour
{
      

    public float health;
    public float timeBDestroy;
    Rigidbody rb;
<<<<<<< HEAD
    public float startForce = 15f;
    public float largeBottlePoints = 20f;

=======
    public AudioClip BreakingGlass;
    public AudioSource MusicSource;
    public Component MeshRender;
>>>>>>> 4f810bddaeff5629260d3d6d2f311c020ef65878
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
<<<<<<< HEAD
        Destroy(gameObject);
        scoreScript.addUp(largeBottlePoints);
=======
        ScoreScript.scoreValue += 5;
        MusicSource.Play();
        Destroy(MeshRender);
        Destroy(gameObject, 1f);
        
>>>>>>> 4f810bddaeff5629260d3d6d2f311c020ef65878
    }
}
