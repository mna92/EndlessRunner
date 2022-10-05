using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGenerator : MonoBehaviour
{
    public GameObject[] ledges;
    public static int ledgePosition = 4;
    public int ledgeNumber;
    public bool creatingLedge = false;
    GameObject clone;
    public static float generatorYield = 0.985f;
    public static int destroyDelay = 10;

    private void Update()
    {
        if (!creatingLedge)
        {
            creatingLedge = true;
            StartCoroutine(GenerateLedge());
        }
    }

    IEnumerator GenerateLedge()
    {

        ledgeNumber = Random.Range(1, 7);
        clone = Instantiate(ledges[ledgeNumber], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        ledgePosition++;
        Destroy(clone, destroyDelay);
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, destroyDelay);
        ledgePosition++;
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, destroyDelay);
        ledgePosition++;
        yield return new WaitForSeconds(generatorYield);
        creatingLedge = false;
    }
}
