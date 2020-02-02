//Sam Baker
using UnityEngine;

public class Health : MonoBehaviour
{
    public float startHealth = 250.0f;
    private float currentHealth;
    public GameObject damageIndication;
    public HitObject hitObject; //0=Boss, 1=player, 2=pillar

    private void Start() => currentHealth = startHealth;

    private void Update() {
        if(currentHealth <= 0) {
            Destroy(gameObject);
        }
    }

    public void TakeBulletDamage(float f_dmg) {

        Debug.Log("Damaging: " + hitObject);

        switch (hitObject)
        {
            case HitObject.Boss:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, Color.red);
                break;
            case HitObject.Player:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, Color.white);
                break;
            case HitObject.Pillar:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, Color.blue);
                break;
        }
    }

    private void DamageNumbers(float f_dmg, Color color)
    {
        Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y, transform.position.z + Random.Range(-0.5f, 0.5f));
        GameObject dmgIndication = Instantiate(damageIndication, spawnPos, Quaternion.identity);

        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().fontSize = 128;
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().text = f_dmg.ToString();
        dmgIndication.transform.GetChild(0).GetComponent<TextMesh>().color = color;  
        dmgIndication.transform.LookAt(Camera.main.transform.position);
        Destroy(dmgIndication, 0.25f);
    }

    public enum HitObject
    {
        Boss,
        Player,
        Pillar
    }
    public enum Type
    {
        Boss,
        Player,
        Pillar
    }
}
