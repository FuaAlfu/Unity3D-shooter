using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.8.28
/// </summary>

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 40.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
