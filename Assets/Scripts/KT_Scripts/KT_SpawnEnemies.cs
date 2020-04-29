using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KT_SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    
    private int enemyCount;

    public int enemySpawnCount;

    private int xPos;
    private int yHeight;
    private int zPos;

    public GameObject poofVFX;

    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        yHeight = 67;

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (enemyCount < enemySpawnCount)
        {
            xPos = Random.Range(405, 280);
            zPos = Random.Range(70, 10);

            Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], new Vector3(xPos, yHeight, zPos), Quaternion.identity);
            Instantiate(poofVFX, new Vector3(xPos, yHeight, zPos), Quaternion.identity);
            Debug.Log("Enemy " + enemyCount + " spawned.");
            yield return new WaitForSeconds(5f);
            enemyCount += 1;
        }
    }
}
