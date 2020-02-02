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
            if (hitObject == HitObject.Pillar) {
                transform.parent.gameObject.SetActive(false);
            } else {
                Destroy(gameObject);
            }
        }
    }

    public void TakeBulletDamage(float f_dmg, Vector3 v3_pos) {

        //Debug.Log("Damaging: " + hitObject);

        switch (hitObject)
        {
            case HitObject.Boss:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, v3_pos, Color.red);
                break;
            case HitObject.Player:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, v3_pos, Color.white);
                break;
            case HitObject.Pillar:
                currentHealth -= f_dmg;
                DamageNumbers(f_dmg, v3_pos, Color.blue);
                break;
        }
    }

    private void DamageNumbers(float f_dmg, Vector3 v3_pos, Color color)
    {
        Vector3 spawnPos = new Vector3(v3_pos.x + Random.Range(-0.5f, 0.5f), v3_pos.y, v3_pos.z + Random.Range(-0.5f, 0.5f));
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
