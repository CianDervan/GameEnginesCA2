
using UnityEngine;

public class target : MonoBehaviour
{

    public float health = 100f;
    public AudioSource exp;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            exp.Play();
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject,1f);
    }

}
