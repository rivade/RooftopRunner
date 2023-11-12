using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownHandler : MonoBehaviour
{
    [SerializeField]
    TMP_Text countdownText;

    float counter = 20.9f;

    void Update()
    {
        counter -= Time.deltaTime;
        countdownText.text = ((int)counter).ToString();

        if (Input.GetKeyDown(KeyCode.Space) || (counter <= 0))
            SceneHandler.GoToScene(2);
    }
}
