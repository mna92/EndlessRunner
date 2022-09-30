using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrashEndGame : MonoBehaviour
{
    public AudioSource crashSound;
    public GameObject ledgeGenerator;
    public GameObject playerObject;
    public GameObject finalScore;
    public GameObject splashBackground;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CrashBox")
        {
            crashSound.Play();
            ledgeGenerator.SetActive(false);
            playerObject.GetComponent<CharacterLocomotion>().enabled = false;
            finalScore.GetComponent<Text>().text = "FINAL SCORE: " + ScoreCubeMonitor.scoreNumber;
            ScoreCubeMonitor.scoreNumber = 0;
            playerObject.transform.position = new Vector3(-2, 1, 1);
            StartCoroutine(SplashEndGame());

        }
    }

    IEnumerator SplashEndGame()
    {
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("BackgroundFadeIn");
        yield return new WaitForSeconds(1f);
        finalScore.SetActive(true);
    }
}
