//Sam Baker
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float startHealth = 250.0f;
    private float currentHealth;
    public GameObject damageIndication;

    private void Start() => currentHealth = startHealth;

    private void Update() {
        if(currentHealth <= 0) {
            Destroy(gameObject);
        }
    }

    public void TakeBulletDamage(float f_dmg) {
        Debug.Log("Working");
        currentHealth -= f_dmg;
        Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y, transform.position.z + Random.Range(-0.5f, 0.5f));
        GameObject dmgIndication = Instantiate(damageIndication, spawnPos, Quaternion.identity);
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().fontSize = 128;
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().text = f_dmg.ToString();
        dmgIndication.transform.LookAt(Camera.main.transform.position);
        Destroy(dmgIndication, 0.25f);
    }
}
