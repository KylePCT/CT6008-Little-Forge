//Sam Baker
////////////////// Temp script for game jam
using System;
using UnityEngine;

public class PillarManager : MonoBehaviour
{
    public GameObject[] pillars;
    public bool[] pillarActive;
    public float[] pillarTimers;
    private bool[] trig;
    private float timer = 0.0f;
    public float pillartime = 10.0f;

    private void Start() {
        timer = 2.0f;
        foreach (GameObject pillar in pillars) {
            pillar.SetActive(true);
        }
        for (int i = 0; i < 5; i++) {
            pillarTimers[i] = pillartime;
            pillarActive[i] = true;
        }
    }

    private void Update() {
        timer -= Time.deltaTime;
        UpdateAllPillars();
        //Check every two seconds
        if (timer <= 0) {
            for (int i = 0; i < pillars.Length; i++) {
                if (pillars[i].activeInHierarchy == false) {
                    if (pillarTimers[i] <= 0.5f) {
                        pillars[i].transform.GetChild(0).GetComponent<Health>().currentHealth = 500;
                        pillars[i].SetActive(true);
                        pillarActive[i] = true;
                    } else {
                        pillarActive[i] = false;
                    }
                }
                
                if (pillarActive[i] == true) {
                    pillars[i].SetActive(true);
                }
            }
            timer = 2.0f;
        }
    }

    private void UpdateAllPillars() {
        if(pillarActive[0] == false) {
            pillarTimers[0] -= Time.deltaTime;
            if(pillarTimers[0] <= 0) {
                pillars[0].SetActive(true);
                pillarActive[0] = true;
            }
        }
        if (pillarActive[1] == false) {
            pillarTimers[1] -= Time.deltaTime;
            if (pillarTimers[1] <= 0) {
                pillars[1].SetActive(true);
                pillarActive[1] = true;
            }
        }
        if (pillarActive[2] == false) {
            pillarTimers[2] -= Time.deltaTime;
            if (pillarTimers[2] <= 0) {
                pillars[2].SetActive(true);
                pillarActive[2] = true;
            }
        }
        if (pillarActive[3] == false) {
            pillarTimers[3] -= Time.deltaTime;
            if (pillarTimers[3] <= 0) {
                pillars[3].SetActive(true);
                pillarActive[3] = true;
            }
        }
        if (pillarActive[4] == false) {
            pillarTimers[4] -= Time.deltaTime;
            if (pillarTimers[4] <= 0.5f) {
                pillars[4].SetActive(true);
                pillarActive[4] = true;
            }
        }
    }
}
