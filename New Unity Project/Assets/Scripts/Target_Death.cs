
using UnityEngine;

public class Target_Death : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 250f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
