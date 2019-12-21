using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    GameObject target;
    Rigidbody2D m_RigidBody2D;
    public float m_MoveSpeed = 3.0f;
    private Vector3 dir;

    private float m_MaxHealth = 5.0f;

    private HealthBarController m_HealthController;
    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.FindGameObjectWithTag("Player");
        this.m_RigidBody2D = GetComponent<Rigidbody2D>();

        this.m_HealthController = this.transform.GetChild(0).GetComponent<HealthBarController>();
        this.m_HealthController.setMaxHealth(this.m_MaxHealth);
    }

    // Update is called once per frame

    void Update()
    {
        if (target.transform != null)
        {
            dir = target.transform.position - this.transform.position;
            this.m_RigidBody2D.MovePosition(this.transform.position + Vector3.Normalize(dir) * this.m_MoveSpeed * Time.deltaTime);

            if (dir.y > 0.0f)
            {
                this.SetBool("back", true);
            }
            else
            {
                this.SetBool("back", false);
            }
        }
    }

    private void SetBool(string Name, bool Value)
    {
        this.GetComponent<Animator>().SetBool(Name, Value);
    }
}
