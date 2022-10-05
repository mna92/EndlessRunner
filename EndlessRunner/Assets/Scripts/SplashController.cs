using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashController : MonoBehaviour
{
    public AudioSource audioBGM;
    public GameObject globalScripts;
    public GameObject logoMark;
    public GameObject tapToStart;
    public GameObject splashBackground;
    public GameObject countDown;
    public GameObject playerObject;
    public AudioSource countdownAudio;
    public GameObject finalScore;
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        audioBGM.enabled = false;
        globalScripts.GetComponent<LedgeGenerator>().enabled = false;
        playerObject.GetComponent<CharacterLocomotion>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        logoMark.SetActive(true);
        logoMark.GetComponent<Animator>().Play("LogoSplashStart");

        yield return new WaitForSeconds(3.8f);
        logoMark.SetActive(false);
        tapToStart.SetActive(true);
        tapToStart.GetComponent<Animator>().Play("TapToStartAnim");
        yield return new WaitForSeconds(1f);
        tapToStart.GetComponent<Button>().enabled = true;
    }

    public void TapToStartButton()
    {
        ScoreCubeMonitor.scoreNumber = 0;
        LedgeGenerator.ledgePosition = 4;
        splashBackground.GetComponent<Animator>().enabled = true;
        splashBackground.GetComponent<Animator>().Play("BackgroundFadeOut");
        tapToStart.SetActive(false);
        StartCoroutine(GameBegin());
    }

    IEnumerator GameBegin()
    {
        finalScore.SetActive(false);
        yield return new WaitForSeconds(1f);
        splashBackground.SetActive(false);
        countDown.SetActive(true);
        countDown.GetComponent<Text>().text = "3";
        countDown.GetComponent<Animator>().Play("CountDownAnim");
        countdownAudio.Play();
        yield return new WaitForSeconds(1f);
        countDown.GetComponent<Text>().text = "2";
        countDown.GetComponent<Animator>().Play("CountDownAnim");
        countdownAudio.Play();
        yield return new WaitForSeconds(1f);
        countDown.GetComponent<Text>().text = "1";
        countDown.GetComponent<Animator>().Play("CountDownAnim");
        countdownAudio.Play();
        yield return new WaitForSeconds(1f);
        countDown.GetComponent<Text>().text = "GO!";
        countDown.GetComponent<Animator>().Play("CountDownAnim");
        countdownAudio.Play();
        yield return new WaitForSeconds(0.5f);
        countDown.SetActive(false);
        audioBGM.enabled = true;
        globalScripts.GetComponent<LedgeGenerator>().enabled = true;
        playerObject.GetComponent<CharacterLocomotion>().enabled = true;
        globalScripts.GetComponent<Difficulty>().enabled = true;
    }
}
