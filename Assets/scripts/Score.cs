using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI text;
    int score;
    float curr;

    private void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();
        score = 0;
        curr = 1;
        text.SetText(score.ToString());
    }

    private void FixedUpdate()
    {
        curr -= Time.fixedDeltaTime;
        if (curr <= 0)
        {
            score++;
            text.SetText(score.ToString());
            curr = 1;
        }
    }
}
