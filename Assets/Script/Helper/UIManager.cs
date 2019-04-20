using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [HideInInspector]
    public float minutes;
    [HideInInspector]
    public float milliseconds;
    [HideInInspector]
    public float seconds;
    [SerializeField]
    private Text counterText;
    [SerializeField]
    private GameObject endGame;

    [SerializeField]
    private Text yourTime;

    [HideInInspector]
    public bool game = true;


    private void Start()
    {
        STF.NullReferences();
    }

    void Update()
    {
        if (game)
        {

            minutes = (int)(Time.timeSinceLevelLoad / 60f) % 60;
            milliseconds = (int)(Time.timeSinceLevelLoad * 1000f) % 1000;
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            counterText.text = minutes.ToString() + ":" + seconds.ToString() + ":" + milliseconds.ToString();
        }
    }

    public void EndGame()
    {
        endGame.SetActive(true);
        yourTime.text = counterText.text;
    }

    public void OnClickRestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitGame()
    {
        Application.Quit();
    }

}
