using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrashEndGame : MonoBehaviour
{
    public AudioSource crashSound, bgm, gameOver;
    public GameObject globalScript;
    public GameObject playerObject;
    public GameObject gameOverFinalScore;
    public GameObject splashBackground;
    public GameObject tapToStart;
    public GameObject mainCameraPosition;
    public GameObject locomotionButtons;
    public GameObject lastScore;
    public int lastScoreValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CrashBox")
        {
            locomotionButtons.SetActive(false);
            lastScoreValue = PlayerPrefs.GetInt("LastScore");
            StartCoroutine(SplashEndGame());
        }
    }

    IEnumerator SplashEndGame()
    {
        bgm.enabled = false;
        crashSound.Play();
        globalScript.GetComponent<LedgeGenerator>().enabled = false;
        playerObject.GetComponent<CharacterLocomotion>().enabled = false;
        gameOverFinalScore.GetComponentInChildren<Text>().text = "FINAL SCORE: " + ScoreCubeMonitor.scoreNumber;
        PlayerPrefs.SetInt("LastScore", ScoreCubeMonitor.scoreNumber);
        lastScore.GetComponent<Text>().text = "LAST SCORE: " + lastScoreValue;

        yield return new WaitForSeconds(1f);
        gameOver.Play();
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("BackgroundFadeIn");

        yield return new WaitForSeconds(1f);
        tapToStart.SetActive(true);
        tapToStart.GetComponent<Animator>().Play("TapToStartAnim");
        playerObject.transform.position = new Vector3(-2, 1, 1);
        mainCameraPosition.transform.position = new Vector3(-2.5f, 5.5f, 1);

        yield return new WaitForSeconds(0.7f);
        gameOverFinalScore.SetActive(true);
        lastScore.SetActive(true);

        yield return new WaitForSeconds(1f);
        tapToStart.GetComponent<Button>().enabled = true;
        locomotionButtons.SetActive(true);
    }
}
