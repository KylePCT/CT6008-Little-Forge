//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Health player;
    public Weapon weapon;
    public Image healthIndication;
    public Image chargeIndication;
    private float startHealth;
    private float startCharge;

    private void Start()
    {
        if(player == null)
        {
            if(GameObject.FindGameObjectWithTag("Player"))
            {
                player = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
            } else
            {
                Debug.LogError("Error: The gameobject tagged 'Player' cannot be found in the scene");
            }
        }
        startHealth = player.startHealth;
    }

    private void Update()
    {
        healthIndication.fillAmount = player.currentHealth / startHealth;
        chargeIndication.fillAmount = weapon.weaponCharge / 100;
    }
}
