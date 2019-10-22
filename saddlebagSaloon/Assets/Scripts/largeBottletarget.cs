using UnityEngine;
using UnityEngine.Scripting;



public class largeBottletarget : MonoBehaviour
{
      

    public float health = 1f;
    Rigidbody rb;
    public float startForce = 15f;
    public float largeBottlePoints = 20f;

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
        Destroy(gameObject);
        scoreScript.addUp(largeBottlePoints);
    }
}
