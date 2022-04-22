using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.16
/// </summary>

public class Coin : MonoBehaviour
{
    [SerializeField]
    CollectionsSO collectionsSO;

    [SerializeField]
    GameObject prefabe;

    bool hasTarget;
    Vector3 targetPosition;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(hasTarget)
        {
            Vector3 targetDirection = (targetPosition - transform.position).normalized;
            rb.velocity = new Vector3(targetDirection.x, targetDirection.y, targetDirection.z) * 5f;
        }
    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.CompareTag("Player"))
        {
            print("enter");
            GetValue();
            Destroy(gameObject,.1f);
        }
    }
    public void GetValue()
    {
        GameSession.Instance.ShowScore(collectionsSO.GetItem());
        Instantiate(prefabe, transform.position, Quaternion.identity);
    }
}
