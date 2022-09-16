using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.9.16
/// </summary>

public class EventsTesters : MonoBehaviour
{
    [field: SerializeField]
    GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.CompareTag("Player"))
        {
            foreach(GameObject g in objects)
            {
                g.SetActive(true);
            }
        }
    }
}
