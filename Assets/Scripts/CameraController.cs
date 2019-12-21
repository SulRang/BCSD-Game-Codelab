using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float follow_speed = 4.0f;
    public float z = -20.0f;
    public GameObject Target;

    Transform this_transform;
    Transform Target_transform;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        this_transform = GetComponent<Transform>();
        Target_transform = Target.GetComponent<Transform>();
    }
    void Update()
    {
        this_transform.position = Vector2.Lerp(this_transform.position, Target_transform.position, follow_speed * Time.deltaTime);
        this_transform.Translate(0, 0, z);
    }
}
