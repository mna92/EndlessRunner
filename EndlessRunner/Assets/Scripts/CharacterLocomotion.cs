using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    public float moveSpeed = 3;


    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
    }
}
