//Sam Baker
//Animation implementation by Kyle Tugwell
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.1f;
    [SerializeField] private float baseDamage = 10;
    [SerializeField] private float damage;
    public MultiMovementV2 player;
    public GameObject orientaion;
    public WEAPON_TYPE weaponType;
    public bool isShooting;
    private float timer;
    private GameObject cam;
    public ParticleSystem muzzleFlash;
    public float weaponCharge;
    public float chargeTakenPerFire;
    public float chargeRate;
    [SerializeField] private Animator placeholderAnims;
    public PlayerSoundsManager audioManager;

    private void Start() {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        timer = fireRate;
        weaponCharge = 100.0f;
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
                    if (weaponCharge <= 0) {
                        placeholderAnims.SetBool("isShooting", false);
                        audioManager.gunAudioSource.pitch = 1.0f;
                        audioManager.gunAudioSource.clip = audioManager.gunclick;
                        audioManager.gunAudioSource.Play();
                        return;
                    } else{
                        weaponCharge -= chargeTakenPerFire;
                        placeholderAnims.SetBool("isShooting", true);
                        audioManager.gunAudioSource.pitch = Random.Range(0.85f, 1.15f);
                        audioManager.gunAudioSource.clip = audioManager.laser;
                        audioManager.gunAudioSource.Play();
                    }
                    ShootAction();
                    timer = fireRate;
                }
            }
        } else {
            //No Shoot
        }
        if (player.shouldCharge) {
            weaponCharge += chargeRate * Time.deltaTime;
            if(weaponCharge > 100) {
                weaponCharge = 100;
            }
        }
    }

    private void ShootAction() {
        MuzzleFlash();

        //Added some damage variation - KT/AP 19/2
        damage = Random.Range((int)(baseDamage * 0.8f), (int)(baseDamage * 1.2f));

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100.0f)) {
            if (hit.transform.tag == "Enemy") {
                hit.transform.GetComponent<Enemy>().TakeBulletDamage(damage);
            } else if (hit.transform.tag == "Boss") {
                hit.transform.GetComponentInParent<Health>().TakeBulletDamage(damage, hit.transform.position);
            } else if (hit.transform.tag == "Pillar") {
                hit.transform.GetComponentInParent<Health>().TakeBulletDamage(damage, hit.transform.position);
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
