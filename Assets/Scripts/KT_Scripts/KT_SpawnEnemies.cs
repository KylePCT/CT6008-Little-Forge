using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    private Vector3 m_randPointOnMesh = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        yHeight = 67;

        StartCoroutine(SpawnEnemy());
    }

    private void OnEnable()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        yHeight = 67;

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (enemyCount < enemySpawnCount)
        {
            //xPos = Random.Range(405, 280);
            //zPos = Random.Range(70, 10);

            //Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], new Vector3(xPos, yHeight, zPos), Quaternion.identity);
            
            //Edited to stop enemies spawning inside of objects - Sam Baker
            m_randPointOnMesh = RandomNavSphere(new Vector3(345f, 67f, 23f), 999f, -1);
            Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], m_randPointOnMesh, Quaternion.identity);
            Instantiate(poofVFX, new Vector3(xPos, yHeight, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemyCount += 1;
        }
    }
    /// <summary>
    /// Function used to get a random point on the navmesh, gets a random point within a sphere. - Sam Baker
    /// </summary>
    /// <param name="a_origin">Center of the sphere.</param>
    /// <param name="a_dist">Radius of the sphere.</param>
    /// <param name="a_layermask"></param>
    /// <returns>Return a Vector3.</returns>
    public static Vector3 RandomNavSphere(Vector3 a_origin, float a_dist, int a_layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * a_dist;
        randDirection += a_origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, a_dist, a_layermask);

        return navHit.position;
    }
}
