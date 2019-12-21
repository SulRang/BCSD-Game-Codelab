using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;
    private Rigidbody2D m_Rigidbody = null;
    private float hori, vert;
    
    // Start is called before the first frame update
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        this.m_Rigidbody.velocity = new Vector2(hori, vert) * m_MoveSpeed;
    }
    
}
