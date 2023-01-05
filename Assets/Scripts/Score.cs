using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    Text text1;

    private void Awake()
    {
        text1 = GetComponent<Text>();
    }

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        text1.text = score.ToString();
    }
}
