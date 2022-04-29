using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.23
/// </summary>

public class TransPointAgreements : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Transform[] movePositions;

    [SerializeField]
    private float moveSpeed = 2f;

    [SerializeField]
    private int direction = 1;

    [SerializeField]
    private bool reverse = false;

    [SerializeField]
    private int start = 0;  //start element .. wow ))

    private int end;

    private int startIndix = 0;
    private int nextIndex = 1;

    private float position = 0;
    private float distance;

    // private bool isMoving;

    private void Awake()
    {
        RestrictStartIndex();
        RestrictDirection();
        DetermineEndPoint();

        startIndix = start;
        nextIndex = startIndix;

        SetNextDestinationIndex();
        SetMovementDistance();
    }

    // Start is called before the first frame update
    void Start()
    {
        //   isWait = false;
    }

    // Update is called once per frame
    void Update()
    {
        position += Time.deltaTime * moveSpeed / distance;
        target.position = Vector3.Lerp(movePositions[startIndix].position, movePositions[nextIndex].position, position);
        if (position >= 1)
        {
            ChangeDestination();
        }
    }

    void RestrictStartIndex()
    {
        if (start > (movePositions.Length - 1))
        {
            start = movePositions.Length - 1;
        }
        else if (start < 0)
        {
            start = 0;
        }
    }

    void RestrictDirection()
    {
        if (direction >= 0)
        {
            direction = 1;
        }
        else if (direction < 0)
        {
            direction = -1;
        }
    }

    void ChangeDestination()
    {
        position = 0;
        SetNextDestinationIndex();
        SetMovementDistance();
    }

    void DetermineEndPoint()
    {
        end = (start + movePositions.Length - direction) % movePositions.Length;
    }

    void SetNextDestinationIndex()
    {
        if (reverse && startIndix != nextIndex)
        {
            DetermineDirection();
        }
        startIndix = nextIndex;
        nextIndex = (startIndix + direction) % movePositions.Length; //direction = 1

        if (nextIndex < 0)
        {
            nextIndex += movePositions.Length;
        }
    }
    void SetMovementDistance()
    {
        distance = Vector3.Distance(movePositions[startIndix].position, movePositions[nextIndex].position);
    }

    void DetermineDirection()
    {
        if (nextIndex == start || nextIndex == end) //nextIndex == 0 and zero is start)) also movePositions.Length - 1 is end.
        {
            direction *= -1;
        }
    }
}
