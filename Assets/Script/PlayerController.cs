using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.20
/// </summary>

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    ParticleSystem p;

    [SerializeField]
    GameObject g;

    public void EffectRun()
    {
        //p.Play();
        g.SetActive(true);
    }

    public void EffectStop()
    {
        //p.Stop();
        g.SetActive(false);
    }
}
