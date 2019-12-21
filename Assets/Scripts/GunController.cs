using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Sprite[] Gun;
    private PlayerController m_PlayerController;
    private SpriteRenderer m_SpriteRenderer;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        this.m_PlayerController = this.transform.parent.GetComponent<PlayerController>();
        this.m_SpriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int dir = this.m_PlayerController.getDir();
        this.m_SpriteRenderer.sprite = this.Gun[dir];

    }

    public void shoot()
    {
        Instantiate(Bullet, this.transform.parent.position, new Quaternion(0, 0, 0, 0));
    }

}