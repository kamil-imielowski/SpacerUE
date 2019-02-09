using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int startingEcts = 0; // startuje od 0 ects
    public int currentEcts;
    public Slider EctsSlider;
    public AudioSource applauseAudioSource;

    bool isPass;

    private void Awake()
    {
        currentEcts = startingEcts;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPass)
        {
            StartCoroutine(LevelChange());
            isPass = false;
        }
    }

    IEnumerator LevelChange()
    {
        var player = GameObject.Find("FPSController");

        AudioSource.PlayClipAtPoint(applauseAudioSource.clip, player.transform.position);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }

    public void AddEcts(int amount)
    {
        currentEcts += amount;
        EctsSlider.value = currentEcts;
        if(currentEcts >= 30 && !isPass)
        {
            Pass();
        }
    }

    void Pass()
    {
        isPass = true;
    }
}
