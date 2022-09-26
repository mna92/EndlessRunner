using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    public GameObject[] characterSelected;
    public int characterNumber;

    private void Start()
    {
        characterNumber = Random.Range(0, 3);
        characterSelected[characterNumber].SetActive(true);

    }
}
