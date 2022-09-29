using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCubeMonitor : MonoBehaviour
{
    public static int scoreNumber;
    public GameObject ScoreDisplay;

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.GetComponentInChildren<Text>().text = "SCORE: " + scoreNumber;
    }
}
