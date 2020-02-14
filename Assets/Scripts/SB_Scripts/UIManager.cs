//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Health player;
    public Image healthIndication;
    private float startHealth;

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
        Debug.Log(player.currentHealth / startHealth);

        healthIndication.GetComponent<Image>().fillAmount = player.currentHealth / startHealth;
    }
}
