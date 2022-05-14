using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.5.14
/// </summary>

public class FollowObject : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    float speed = 4f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currebntPosition = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        rb.MovePosition(currebntPosition);
        transform.LookAt(target);
    }
}
