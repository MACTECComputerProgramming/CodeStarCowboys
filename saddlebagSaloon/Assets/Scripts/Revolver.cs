using UnityEngine;

public class Revolver : MonoBehaviour
{

    public float damage = 1f;
    public float range = 100f;
    
    

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioClip gunFire;
    public AudioSource soundSource;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            soundSource.clip = gunFire;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
       if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            soundSource.Play();
            muzzleFlash.Play();

            largeBottletarget target = hit.transform.GetComponent<largeBottletarget>();
            timeUpTarget timeTarget = hit.transform.GetComponent<timeUpTarget>();
            smallTarget smallTarget = hit.transform.GetComponent<smallTarget>();
            shotGlass shotGlass = hit.transform.GetComponent<shotGlass>();
            reduceTimeTarget reduceTimeTarget = hit.transform.GetComponent<reduceTimeTarget>();


            if(target != null)
            {
                target.TakeDamage(damage);
            }
            else if(timeTarget != null)
            {
                timeTarget.TakeDamage(damage);
            }
            else if (smallTarget != null)
            {
                smallTarget.TakeDamage(damage);
            }
            else if (shotGlass != null)
            {
                shotGlass.TakeDamage(damage);
            }
            else if (reduceTimeTarget != null)
            {
                reduceTimeTarget.TakeDamage(damage);
            }
        }

    }
}
