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

        ledgeNumber = Random.Range(1, 7);
        clone = Instantiate(ledges[ledgeNumber], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        ledgePosition++;
        Destroy(clone, 6);
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, 6);
        ledgePosition++;
        clone = Instantiate(ledges[0], new Vector3(ledgePosition, 0, 1), Quaternion.identity);
        Destroy(clone, 6);
        ledgePosition++;
        yield return new WaitForSeconds(1);
        creatingLedge = false;
    }
}
