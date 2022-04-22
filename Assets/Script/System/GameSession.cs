using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/// <summary>
/// 2022.4.16
/// </summary>

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;

    [SerializeField]
    TMP_Text txt;

    int score;

    private void Awake()
    {
            Instance = this;
    }
    private void Start()
    {
        txt.text = score.ToString();
    }

    public void ShowScore(int scoring)
    {
        score += scoring;
        txt.text = score.ToString();
    }
}
