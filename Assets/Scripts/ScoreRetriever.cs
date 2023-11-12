using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRetriever : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    void Start()
    {
        scoreText.text = $"{(int)PlayerPrefs.GetFloat("Score")}";
    }
}
