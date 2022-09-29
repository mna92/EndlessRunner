using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerObject")
        {
            ScoreCubeMonitor.scoreNumber += 10;
        }
    }
}
