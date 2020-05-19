
using UnityEngine;

public class Target_Death : MonoBehaviour
{

    public float health = 250f;
    public AudioSource exp;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            exp.Play();
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject,6f);
    }
}
