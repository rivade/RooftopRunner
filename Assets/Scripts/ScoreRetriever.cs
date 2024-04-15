using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRetriever : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    [SerializeField]
    TMP_Text hiScoreText;
    void Start()
    {
        scoreText.text = $"{(int)PlayerPrefs.GetFloat("Score")}";
        hiScoreText.text = $"{(int)PlayerPrefs.GetFloat("HighScore")}";
    }
}
