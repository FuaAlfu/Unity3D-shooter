using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 2022.4.22
/// </summary>

public class Magnet : MonoBehaviour
{
    public Transform port;
    private void OnTriggerStay(Collider c)
    {
        if (c.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            print("Entered...");
           // coin.SetTarget(port.parent.position);
            coin.SetTarget(port.position);
        }
    }
}
