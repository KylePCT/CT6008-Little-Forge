//Sam Baker
using UnityEngine;
using UnityEngine.UI;

public class PillarHealthIndication : MonoBehaviour
{
    public Camera cam;
    private Health health;
    private float startHealth;
    private float currentHealth;
    public Image healthBar;
    private void Start()
    {
        health = gameObject.transform.parent.GetComponent<Health>();
        startHealth = health.startHealth;
        cam = Camera.main;
    }

    private void Update()
    {
        currentHealth = health.currentHealth;
        healthBar.fillAmount = currentHealth / startHealth; 
        Vector3 v = cam.transform.position - transform.position;
        v.x = v.z = 0.0f;

        transform.LookAt(cam.transform.position - v);
        //transform.Rotate(0, 180, 0);
    }
}
