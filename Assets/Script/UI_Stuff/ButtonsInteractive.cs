using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.22
/// </summary>

public class ButtonsInteractive : MonoBehaviour
{
    
    public AudioClip hoverFVX, clickFVX;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Hover()
    {
        audioSource.PlayOneShot(hoverFVX);
    }

    public void Click()
    {
        audioSource.PlayOneShot(clickFVX);
    }
}
