//Sam Baker
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;

    private void Update() {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float f_damage) {
        health -= f_damage * Time.deltaTime;
    }
}
