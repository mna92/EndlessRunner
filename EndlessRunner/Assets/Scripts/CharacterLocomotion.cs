using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    public static float moveSpeed = 3f;


    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
    }
}
