using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.16
/// </summary>

[CreateAssetMenu(menuName = "tools/collections", fileName = "new_collect")]
public class CollectionsSO : ScriptableObject
{
    [SerializeField]
    int item;

    public int GetItem()
    {
        return item;
    }
}
