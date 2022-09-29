using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject mainCamera;
    public int zPos;
    public float xPos;

    private void Update()
    {
        xPos = playerObject.gameObject.transform.position.x;
    }

    public void MoveRight()
    {
        if (zPos == 0)
        {
            zPos = 0;
        }
        else
        {
            zPos--;
        }
        playerObject.gameObject.transform.position = new Vector3(xPos, 1, zPos);
        mainCamera.transform.position = new Vector3(xPos - 0.5f, 5.5f, 1);
    }

    public void MoveLeft()
    {
        if (zPos == 2)
        {
            zPos = 2;
        }
        else
        {
            zPos++;
        }
        playerObject.gameObject.transform.position = new Vector3(xPos, 1, zPos);
        mainCamera.transform.position = new Vector3(xPos - 0.5f, 5.5f, 1);
    }
}
