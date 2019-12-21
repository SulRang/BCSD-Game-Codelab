using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;
    private Rigidbody2D m_Rigidbody = null;
    private float hori, vert;

    private Transform m_ChildTransform;
    private Animator m_Animator = null;
    private SpriteRenderer m_SpriteRenderer = null;
    private bool m_isright = true;
    // Start is called before the first frame update
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();

        this.m_ChildTransform = this.transform.GetChild(0);
        this.m_Animator = m_ChildTransform.GetComponent<Animator>();
        this.m_SpriteRenderer = m_ChildTransform.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");

        this.UpdateAnimations();
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
}
