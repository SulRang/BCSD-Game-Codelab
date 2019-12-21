using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float m_livetime;
    private Vector2 dir;
    public float m_BulletSpeed = 1.0f;
    private PlayerController m_PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        m_livetime = 0.0f;
        dir = m_PlayerController.getDirection();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * m_BulletSpeed * Time.deltaTime);
        m_livetime += Time.deltaTime;
        if (m_livetime > 5.0f || dir == new Vector2(0, 0))
            Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Monster")
            Destroy(this.gameObject);
    }
}