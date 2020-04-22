//////////////////////////////////////////////////
/// File: UIManager.cs
/// Author: Sam Baker / Zack
/// Date created: 01/02/20
/// Last edit: 
/// Description: Script utilised by any object that can take damage.
/// Comments:
//////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //////////////////////////////////////////////////
    //// Variables
    public float startHealth = 2000.0f;
    public float currentHealth;
    public GameObject damageIndication;
    public HitObject hitObject; //0=Boss, 1=player, 2=pillar

    private float m_healAmount = 25f;
    private int m_healers = 0;
    private float m_healFrequency = 2f;
    private float m_lastHeal = 0f;

    //////////////////////////////////////////////////
    //// Functions
    private void Start() => currentHealth = startHealth;

    private void Update() {

        CheckHealth();

        UpdateHeal();

        CheatsIGuess();
    }

    private void CheckHealth()
    {
        if (currentHealth <= 0)
        {
            if (hitObject == HitObject.Pillar)
            {
                gameObject.SetActive(false);
            }
            if (hitObject == HitObject.Player)
            {
                SceneManager.LoadScene("BossLevel");
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void UpdateHeal()
    {
        if (Time.time - m_lastHeal > m_healFrequency)
        {
            m_lastHeal = Time.time;
            Heal();
        }
    }

    private void CheatsIGuess()
    {
        if (hitObject == HitObject.Player)
        {
            if (Input.GetKey(KeyCode.C))
            {
                currentHealth -= 33 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.V))
            {
                currentHealth += 33 * Time.deltaTime;
            }
        }
    }

    public void TakeBulletDamage(float f_dmg, Vector3 v3_pos) {
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

    public void AddHealer()
    {
        ++m_healers;
    }

    public void RemoveHealer()
    {
        m_healers = Mathf.Clamp(--m_healers, 0, int.MaxValue);
    }

    private void Heal()
    {
        currentHealth = Mathf.Clamp(currentHealth + (m_healAmount * m_healers), 0f, startHealth);
    }

    public enum HitObject
    {
        Boss,
        Player,
        Pillar
    }
}
