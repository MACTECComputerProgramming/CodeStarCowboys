using UnityEngine;

public class largeBottletarget : MonoBehaviour
{

    public float health;
    public float timeBDestroy;
    Rigidbody rb;

    public void Start()
    {
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
    {
        Destroy(gameObject);
        ScoreScript.scoreValue += 5;
    }
}
