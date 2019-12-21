﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    GameObject target;
    Rigidbody2D m_RigidBody2D;
    public float m_MoveSpeed = 3.0f;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.FindGameObjectWithTag("Player");
        this.m_RigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (target.transform != null)
        {
            dir = target.transform.position - this.transform.position;
            this.m_RigidBody2D.MovePosition(this.transform.position + Vector3.Normalize(dir) * this.m_MoveSpeed * Time.deltaTime);
            
        }
    }
}
