using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;

    private float hori, vert, m_MaxHealth = 100.0f;
    private Rigidbody2D m_Rigidbody = null;
    private Animator m_Animator = null;
    private SpriteRenderer m_SpriteRenderer = null;
    private bool m_isright = true;
    private Vector2 m_ForceUpdate = Vector2.zero;
    private HealthBarController m_HealthController;
    private Transform m_ChildTransform;
    private GunController m_GunController;
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();
        this.m_HealthController = this.transform.GetChild(1).GetComponent<HealthBarController>();
        this.m_ChildTransform = this.transform.GetChild(0);
        this.m_Animator = m_ChildTransform.GetComponent<Animator>();
        this.m_SpriteRenderer = m_ChildTransform.GetComponent<SpriteRenderer>();
        this.m_HealthController.setMaxHealth(m_MaxHealth);
        this.m_GunController = this.transform.GetChild(2).GetComponent<GunController>();
    }

    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
        this.UpdateAnimations();
        if (Input.GetKeyDown("space"))
            this.m_GunController.shoot();
    }

    void FixedUpdate()
    {
        this.m_Rigidbody.velocity = new Vector2(hori, vert) * m_MoveSpeed;
    }
    private void UpdateAnimations()
    {
        Vector3 dir = m_ChildTransform.localScale;
        if (vert > 0.0f)
            this.SetBool("up", true);

        else if (vert < -0.0f)
            this.SetBool("down", true);

        else
        {
            this.SetBool("up", false);
            this.SetBool("down", false);
        }

        if (hori > 0.0f)
        {
            this.SetBool("side", true);
            if (!this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = true;
            }
        }
        else if (hori < -0.0f)
        {
            this.SetBool("side", true);
            if (this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = false;
            }
        }
        else
            this.SetBool("side", false);
    }

    private void SetBool(string Name, bool Value)
    {
        this.m_Animator.SetBool(Name, Value);
    }

    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Monster")
        {
            this.m_HealthController.Damaged(1.0f);
            if (this.m_HealthController.getCurrentHealth() <= 0)
                this.Dead();
        }
    }

    private void Dead()
    {
        Destroy(this.gameObject);
    }

    public int getDir()
    {
        if (this.m_Animator.GetBool("up"))
        {
            if (this.m_Animator.GetBool("side"))
                return 1;
            else
                return 4;
        }
        else if (this.m_Animator.GetBool("down"))
        {
            if (this.m_Animator.GetBool("side"))
                return 0;
            else
                return 2;
        }
        else
            return 3;
    }
    public Vector3 getDirection()
    {
        return new Vector3(hori, vert, 0);
    }
}

