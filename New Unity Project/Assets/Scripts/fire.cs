
using UnityEngine;

public class fire : MonoBehaviour
{
    public float damage = 50f;
    public float range = 200f;

    public Camera TPS_Cam;

    public ParticleSystem Left_Fire;
    public ParticleSystem Right_Fire;

    public AudioSource sound;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            sound.Play();
        }
    }

    void Shoot()
    {
        Left_Fire.Play();
        Right_Fire.Play();

        RaycastHit hit;
       if(Physics.Raycast(TPS_Cam.transform.position, TPS_Cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target_Destroyer Target1 = hit.transform.GetComponent<Target_Destroyer>();
            if (Target1 != null)
            {
                Target1.TakeDamage(damage);
            }


            target Target = hit.transform.GetComponent<target>();
            if(Target != null)
            {
                Target.TakeDamage(damage);
            }
        }
    }
}
