using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    GameObject target;
    Rigidbody2D m_RigidBody2D;
    Animator m_Animator;
    public float m_MoveSpeed = 3.0f;
    private float m_MaxHealth = 5.0f;
    private HealthBarController m_HealthController;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.FindGameObjectWithTag("Player");
        this.m_HealthController = this.transform.GetChild(0).GetComponent<HealthBarController>();
        this.m_HealthController.setMaxHealth(this.m_MaxHealth);
        this.m_Animator = this.GetComponent<Animator>();
        this.m_RigidBody2D = GetComponent<Rigidbody2D>();
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
        this.m_Animator.SetBool(Name, Value);
    }

    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Player" || Collider.transform.tag == "Bullet")
        {
            this.m_HealthController.Damaged(1.0f);

            if (this.m_HealthController.getCurrentHealth() <= 0)
            {
                this.Dead();
            }
            this.KnockBack(Collider);
        }
    }

    void Dead()
    {
        Destroy(this.gameObject);
    }

    void KnockBack(Collision2D target)
    {
        this.transform.position -= (target.transform.position - this.transform.position) * 30 * Time.deltaTime;
    }
}
