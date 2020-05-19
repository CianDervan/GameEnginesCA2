
using UnityEngine;

public class Target_Destroyer : MonoBehaviour
{
    public AudioSource exp;

    // Start is called before the first frame update
    public float health = 250f;

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
        Destroy(gameObject);
    }
}
