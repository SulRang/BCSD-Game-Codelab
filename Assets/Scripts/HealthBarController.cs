using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    private Transform target = null;
    private float m_health;
    private float m_max_health;
    private bool is_init = false;
    private Transform bar = null;
    // Start is called before the first frame update
    void Start()
    {
        bar = this.transform.GetChild(0);
        m_health = m_max_health;
        target = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        bar.localScale = new Vector3(m_health / m_max_health, 1);
        this.transform.position = new Vector3(target.position.x, target.position.y + 0.5f);

    }
    public void Damaged(float damage)
    {
        m_health -= damage;
    }
    public float getCurrentHealth()
    {
        return m_health;
    }
    public void setMaxHealth(float targetMaxHealth)
    {
        m_max_health = targetMaxHealth;
        if (!is_init)
            m_health = m_max_health;
    }
}
