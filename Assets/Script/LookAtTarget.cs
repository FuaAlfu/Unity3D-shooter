using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [field: SerializeField]
    GameObject target;

    [field: SerializeField]
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.gameObject.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
