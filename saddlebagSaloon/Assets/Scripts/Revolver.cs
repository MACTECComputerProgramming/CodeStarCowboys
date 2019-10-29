using UnityEngine;

public class Revolver : MonoBehaviour
{

    public float damage = 1f;
    public float range = 100f;
    public float impactForce = 30f;
    

    public Camera fpsCam;
    //public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            //muzzleFlash.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
       if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

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
            

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            //GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(impactGO, 2f)

        }

    }
}
