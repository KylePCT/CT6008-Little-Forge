using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{

    [SerializeField] private GameObject m_spritePrefab = null;
    [SerializeField] private GameObject m_lineRendererPrefab = null;
    [SerializeField] private Transform m_spriteHolder = null;
    [SerializeField] private int m_prefabInstantiateCount = 25;

    [Space(10f)]

    [SerializeField] private float m_spriteWanderDistance = 5f;
    [SerializeField] private float m_spriteWanderTolerance = 0.1f;
    [SerializeField] private float m_spriteSpeed = 1f;
    [SerializeField] private float m_lineFadeSpeed = 1f;

    [System.Serializable]
    private class IndexPair
    {
        public int index1;
        public int index2;
    }

    [System.Serializable]
    private class SpritePosition
    {
        public string name = null;
        public List<Vector2> positions = null;
        public List<IndexPair> lineRendererIndices = null;
        public float scale = 1;
        public Vector2 globalOffset = Vector2.zero;
        public bool debug = false;
    }

    [Space(10f)]

    [SerializeField] private List<SpritePosition> m_spriteData = null;

    [System.Serializable]
    private enum SpriteControllerState
    {
        Wander,
        DisplaySetup,
        DisplayWait
    }

    [Space(10f)]

    [SerializeField] private SpriteControllerState m_state = SpriteControllerState.Wander;
    [SerializeField] private int m_displayIndex = 0;

    [Space(10f)]

    [SerializeField] private float m_stateSwitchFrequency = 4f;
    private float m_lastStateSwitchTime = 0f;

    private List<LineRendererController> m_lineRenderers = null;
  
    private class Sprite
    {
        public Transform transform;
        public Vector2 velocity;
        public bool atTargetPosition = false;

        public Sprite(Transform a_transform, Vector2 a_velocity)
        {
            transform = a_transform;
            velocity = a_velocity;
        }
    }

    private List<Sprite> m_sprites = null;

    private void Awake()
    {
        CreateLineRenderers();

        CreateSprites();
    }

    private void CreateLineRenderers()
    {
        m_lineRenderers = new List<LineRendererController>(m_prefabInstantiateCount);

        for (int i = 0; i < m_prefabInstantiateCount; ++i)
        {
            LineRendererController lineRenderer = Instantiate(m_lineRendererPrefab, transform).GetComponent<LineRendererController>();
            m_lineRenderers.Add(lineRenderer);
            lineRenderer.enabled = false;
        }
    }

    private void CreateSprites()
    {
        m_sprites = new List<Sprite>(m_prefabInstantiateCount);

        for (int i = 0; i < m_prefabInstantiateCount; ++i)
        {
            GameObject sprite = Instantiate(m_spritePrefab);
            if (m_spriteHolder == null)
                sprite.transform.parent = transform;
            else
                sprite.transform.parent = m_spriteHolder;

            Vector2 randomVelocity = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
            sprite.transform.localPosition = new Vector3(UnityEngine.Random.Range(-m_spriteWanderDistance, m_spriteWanderDistance), UnityEngine.Random.Range(-m_spriteWanderDistance, m_spriteWanderDistance), 0f);
            m_sprites.Add(new Sprite(sprite.transform, randomVelocity.normalized));
        }
    }

    private void DisableLineRenderers()
    {
        foreach(LineRendererController lr in m_lineRenderers)
        {
            lr.Fade(m_lineFadeSpeed, 0f);
        }
    }

    private void ResetSpriteSettings()
    {
        foreach(Sprite s in m_sprites)
        {
            s.atTargetPosition = false;
        }
    }

    private void Update()
    {


        UpdateSprites();
    }

    private void UpdateSprites()
    {
        switch(m_state)
        {
            case SpriteControllerState.Wander:
                {
                    SpriteWander();

                    if (Time.time - m_lastStateSwitchTime > m_stateSwitchFrequency)
                    {
                        m_state = SpriteControllerState.DisplaySetup;

                        // Next displayIndex
                        //m_displayIndex = (m_displayIndex + 1) % m_spriteData.Count;
                        // Random displayIndex
                        int index = m_displayIndex;
                        while (index == m_displayIndex)
                            m_displayIndex = UnityEngine.Random.Range(0, m_spriteData.Count);

                        m_lastStateSwitchTime = Time.time;

                        if (m_sprites != null)
                            m_sprites.Shuffle();
                    }

                    break;
                }
            case SpriteControllerState.DisplaySetup:
                {
                    SpriteDisplaySetup();
                    break;
                }
            case SpriteControllerState.DisplayWait:
                {
                    SpriteDisplayWait();
                    break;
                }
        }
    }

    private void SpriteWander(int a_indexOffset = 0)
    {
        Vector2 center = transform.position;

        for (int i = a_indexOffset; i < m_sprites.Count; ++i)
        {
            if (Vector2.Distance(center, m_sprites[i].transform.localPosition) < m_spriteWanderDistance)
            {
                Vector2 randomVelocity = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
                m_sprites[i].velocity = Vector2.Lerp(m_sprites[i].velocity, randomVelocity, m_spriteWanderTolerance * 3f).normalized;
            }
            else
            {
                Vector2 directionToCenter = center - new Vector2(m_sprites[i].transform.localPosition.x, m_sprites[i].transform.localPosition.y);
                m_sprites[i].velocity = Vector2.Lerp(m_sprites[i].velocity, directionToCenter, m_spriteWanderTolerance).normalized;
            }

            Vector2 dir = (m_sprites[i].velocity * Time.deltaTime * m_spriteSpeed);
            float zPos = Mathf.MoveTowards(m_sprites[i].transform.localPosition.z, 0f, Time.deltaTime);
            m_sprites[i].transform.localPosition = new Vector3(m_sprites[i].transform.localPosition.x + dir.x, m_sprites[i].transform.localPosition.y + dir.y, zPos);
        } 
    }

    private void SpriteDisplaySetup()
    {
        if (m_spriteData == null)
        {
            m_state = SpriteControllerState.Wander;
            return;
        }

        for (int i = 0; i < m_spriteData[m_displayIndex].positions.Count; ++i)
        {
            float zTarget = -1f;

            Vector2 target = (m_spriteData[m_displayIndex].positions[i] + m_spriteData[m_displayIndex].globalOffset) * m_spriteData[m_displayIndex].scale;
            Vector2 targetPos = Vector2.MoveTowards(new Vector2(m_sprites[i].transform.localPosition.x, m_sprites[i].transform.localPosition.y), target, Time.deltaTime * m_spriteSpeed);
            float zPos = Mathf.MoveTowards(m_sprites[i].transform.localPosition.z, zTarget, Time.deltaTime * m_spriteSpeed);
            m_sprites[i].transform.localPosition = new Vector3(targetPos.x, targetPos.y, zPos);

            if (Vector3.Distance(m_sprites[i].transform.localPosition, new Vector3(target.x, target.y, zTarget)) == 0f)
                m_sprites[i].atTargetPosition = true;
        }

        bool allPointsInPosition = true;

        for (int i = 0; i < m_spriteData[m_displayIndex].lineRendererIndices.Count; ++i)
        {
            int index1 = m_spriteData[m_displayIndex].lineRendererIndices[i].index1;
            int index2 = m_spriteData[m_displayIndex].lineRendererIndices[i].index2;
            if (m_sprites[index1].atTargetPosition && m_sprites[index2].atTargetPosition)
            {
                m_lineRenderers[i].Fade(m_lineFadeSpeed, 1f);
                m_lineRenderers[i].SetPosition(0, m_sprites[index1].transform.position);
                m_lineRenderers[i].SetPosition(1, m_sprites[index2].transform.position);
            }
            else
            {
                m_lineRenderers[i].Fade(m_lineFadeSpeed, 0f);
                allPointsInPosition = false;
            }
        }

        if (allPointsInPosition)
        {
            m_state = SpriteControllerState.DisplayWait;
            m_lastStateSwitchTime = Time.time;
        }

        SpriteWander(m_spriteData[m_displayIndex].positions.Count);
    }

    private void SpriteDisplayWait()
    {
        if (Time.time - m_lastStateSwitchTime > m_stateSwitchFrequency)
        {
            m_state = SpriteControllerState.Wander;
            m_lastStateSwitchTime = Time.time;
            ResetSpriteSettings();
            DisableLineRenderers();
        }
        
        SpriteWander(m_spriteData[m_displayIndex].positions.Count);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, m_spriteWanderDistance * 0.5f);

        Gizmos.color = Color.magenta;

        for(int i = 0; i < m_spriteData.Count; ++i)
        {
            if (!m_spriteData[i].debug)
                continue;

            Gizmos.DrawSphere((m_spriteData[i].positions[0] + m_spriteData[i].globalOffset) * m_spriteData[i].scale, 0.05f);
            for (int j = 1; j < m_spriteData[i].positions.Count; ++j)
            {
                Gizmos.DrawSphere((m_spriteData[i].positions[j] + m_spriteData[i].globalOffset) * m_spriteData[i].scale, 0.05f);
            }

        }
    }
}


///
/// Source:
/// https://forum.unity.com/threads/clever-way-to-shuffle-a-list-t-in-one-line-of-c-code.241052/
/// 
public static class IListExtensions
{
    /// <summary>
    /// Shuffles the element order of the specified list.
    /// </summary>
    public static void Shuffle<T>(this IList<T> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}