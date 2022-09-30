using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashEndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerObject")
        {
            Debug.Log("Crash");
        }
    }
}
