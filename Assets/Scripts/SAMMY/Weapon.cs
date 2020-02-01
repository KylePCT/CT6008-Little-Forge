//Sam Baker
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.1f;
    [SerializeField] private float damage = 5;
    public GameObject orientaion;
    public GameObject bulletObject;
    public WEAPON_TYPE weaponType;
    public bool isShooting;
    private float timer;
    private GameObject cam;
    public ParticleSystem muzzleFlash;

    private void Start() {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        timer = fireRate;
    }

    private void Update() {
        if (isShooting) {
            //Shoot
            if (GameObject.FindGameObjectWithTag("Player") != null) {
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerZoomIn>().zoomIn == false) {
                    isShooting = false;
                    return;
                }
                timer -= Time.deltaTime;
                if (timer <= 0.0f) {
                    ShootAction();
                    timer = fireRate;
                }
            }
        } else {
            //No Shoot
        }
    }

    private void ShootAction() {
        MuzzleFlash();

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100.0f)) {
            if (hit.transform.tag == "Enemy") {
                //hit.transform.GetComponent<Enemy>().TakeBulletDamage(damage);
            } else {
                //DO NOTHING
            }
        } else {
            //DO NOTHING
        }
    }

    private void MuzzleFlash() {
        muzzleFlash.Play(true);
    }

    public void ShootTrigger(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            if (isShooting) {
                isShooting = false;
            } else {
                if (GameObject.FindGameObjectWithTag("Player") != null) {
                    if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerZoomIn>().zoomIn) {
                        isShooting = true;
                    } else {
                        return;
                    }
                }
            }
        }
    }

    public enum WEAPON_TYPE {
        AUTOMATIC,
        SINGLE_FIRE
    };
}
