//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health;
    public GameObject damageIndication;

    private void Update() {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }

    public void TakeBulletDamage(float f_damage) {
        health -= f_damage;
        Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y, transform.position.z + Random.Range(-0.5f, 0.5f));
        GameObject dmgIndication = Instantiate(damageIndication, spawnPos, Quaternion.identity);
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().text = f_damage.ToString();
        dmgIndication.transform.LookAt(Camera.main.transform.position);
        Destroy(dmgIndication, 0.25f);
    }

    public void TakeDamage(float f_damage) {
        health -= f_damage * Time.deltaTime;
    }
}
