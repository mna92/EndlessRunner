using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static float timePast = 0;

    private void Update()
    {
        timePast += Time.deltaTime;
        if (timePast >= 30)
        {
            timePast = 0;
            CharacterLocomotion.moveSpeed += 0.5f;
            LedgeGenerator.generatorYield -= 0.2f;
            LedgeGenerator.destroyDelay += 10;
        }
    }
}
