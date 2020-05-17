
using UnityEngine;

public class fire : MonoBehaviour
{
    public float damage = 50f;
    public float range = 200f;

    public Camera TPS_Cam;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
       if(Physics.Raycast(TPS_Cam.transform.position, TPS_Cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target Target = hit.transform.GetComponent<target>();
            if(Target != null)
            {
                Target.TakeDamage(damage);
            }
        }
    }
}
