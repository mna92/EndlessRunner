using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGenerator : MonoBehaviour
{
    public GameObject[] ledges;
    public int ledgePosition = 4;
    public int ledgeNumber;
    public bool creatingLedge = false;
    GameObject clone;

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

        ledgeNumber = Random.Range(0, 7);
        clone = Instantiate(ledges[ledgeNumber], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        ledgePosition++;
        Destroy(clone, 8);
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, 8);
        ledgePosition++;
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, 8);
        ledgePosition++;
        yield return new WaitForSeconds(1);
        creatingLedge = false;
    }
}
