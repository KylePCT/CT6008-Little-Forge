//Last Edit: Make a maximum of 10 enemies spawned on screen at once
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KT_SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    
    [SerializeField]private int enemyCount;

    [Tooltip("Max enemies spawned at once")] //SB
    public int m_enemySpawnCount;

    public int xPos;
    private int yHeight;
    public int zPos;

    public GameObject poofVFX;

    private GameObject Player;

    //SB
    private Vector3 m_randPointOnMesh = Vector3.zero;
    private int m_totalEnemiesKilled = 0;
    private float m_timer = 0;
    private float m_spawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        yHeight = 67;
    }

    private void OnEnable()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        yHeight = 67;

    }


    private void Update()
    {
        //Redone to allow enemies to spawn forever but limit the amount at once // SB
        if (m_enemySpawnCount > enemyCount) // SB
        {
            if (m_timer >= m_spawnInterval)
            {
                m_timer = 0;
                //Edited to stop enemies spawning inside of objects - Sam Baker
                m_randPointOnMesh = RandomNavSphere(new Vector3(xPos, 67f, zPos), 40f, -1);
                GameObject go = Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], m_randPointOnMesh, Quaternion.identity);
                Instantiate(poofVFX, m_randPointOnMesh, Quaternion.Euler(0, 0, 0));
                go.GetComponent<ObjectHealth>().SetSpawner(this);

                KT_AudioManager.instance.playSound("Poof");

                enemyCount += 1;
            }
            else
            {
                m_timer += Time.deltaTime;
            }
            
        }
        else
        {
            //Wait for enemies to die...
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
    //Called when an enemy dies - SB
    public void EnemyHasDied()
    {
        enemyCount-=1;
        CheckQuest();
    }
    //Checking quests - SB
    private void CheckQuest()
    {
        if (QuestManager.Instance.CurrentQuestGiver() == null)
        {
            return;
        }
        else if (QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().name == "SB_Kill10Slimes")
        {
            m_totalEnemiesKilled += 1;
            if (m_totalEnemiesKilled == QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().m_amount)
            {
                QuestManager.Instance.CurrentQuestGiver().GetCurrentQuest().SetCompleted(true);
            }
        }
    }
}
