using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 2022.4.28
/// </summary>

public class EnemyBasicAINaveMeshAgent : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    private float chaseRange = 5f;

    [SerializeField]
    private float turnSpeed = 5f;

    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
      agent = GetComponent<NavMeshAgent>();

      target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }

        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void EngageTarget()
    {
        FaceTarget();
        if (distanceToTarget >= agent.stoppingDistance)
        {
            ChaseTarget();
        }

        else if (distanceToTarget <= agent.stoppingDistance)
        {
            // AttackTarget();
            agent.isStopped = true;
        }
    }

    void ChaseTarget()
    {
       // GetComponent<Animator>().SetBool("attack", false);
      //  GetComponent<Animator>().SetTrigger("move");
        agent.SetDestination(target.position);
        //audioSource.PlayOneShot(chaseSFX);
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }
}
