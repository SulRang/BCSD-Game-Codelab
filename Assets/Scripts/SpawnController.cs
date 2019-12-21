using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    private int m_MonsterCount = 0;
    private float m_SpawnVertical, m_SpawnHorizontal;
    private float m_Distance = 5.0f;
    public GameObject m_MonsterObject = null;
    public int m_MaxMonsterCount = 1;

    // Update is called once per frame
    void Update()
    {
        this.m_SpawnHorizontal = Random.Range(-m_Distance, m_Distance);
        this.m_SpawnVertical = Mathf.Sqrt(Mathf.Pow(this.m_Distance, 2.0f) - Mathf.Pow(this.m_SpawnHorizontal, 2.0f));
        this.m_MonsterCount = this.transform.childCount;
        if (m_MonsterCount < m_MaxMonsterCount)
        {
            GameObject.Instantiate(m_MonsterObject, new Vector3(this.m_SpawnHorizontal, this.m_SpawnVertical, -1.0f), new Quaternion(0, 0, 0, 0)).transform.parent = this.transform;
        }
    }
}
