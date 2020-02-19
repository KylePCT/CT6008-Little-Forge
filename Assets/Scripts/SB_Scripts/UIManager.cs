//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Health player;
    public Weapon weapon;
    public Health boss;
    public Image healthIndication;
    public Image chargeIndication;
    public Image bossHealthIndication;
    private float startHealth;
    private float startCharge;
    private float startBossHealth;

    private void Start()
    {
        if(player == null)
        {
            if(GameObject.FindGameObjectWithTag("Player"))
            {
                player = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
            } else
            {
                Debug.LogError("Error: The gameobject tagged 'Player' cannot be found in the scene.");
            }
        }
        startHealth = player.startHealth;
        startBossHealth = boss.startHealth;
    }

    private void Update()
    {
        healthIndication.fillAmount = player.currentHealth / startHealth;
        chargeIndication.fillAmount = weapon.weaponCharge / 100;
        if (boss != null)
        {
            bossHealthIndication.fillAmount = boss.currentHealth / startBossHealth;
        }
    }
}
