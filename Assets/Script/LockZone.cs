using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class LockZone : MonoBehaviour
{

    
    public GameObject player;

    ThirdPersonController th;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        th = FindObjectOfType<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject == player)
        {
            th.JumpHeight = 7.2f;
            FindObjectOfType<PlayerController>().EffectRun();
            //GetComponent<GlobalFog>().enabled = false;
            // GetComponent<SkinnedMeshToMesh>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject == player)
        {
            //  GetComponent<SkinnedMeshToMesh>().enabled = false;
            th.JumpHeight = 1.2f;
            FindObjectOfType<PlayerController>().EffectStop();
        }
    }
}
