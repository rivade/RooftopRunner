using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    static float score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        score += 0.1f;
        scoreText.text = "Score: " + (int)score;
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("Score", score);
        PlayerPrefs.Save();
    }
}
