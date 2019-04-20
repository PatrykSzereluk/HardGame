using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private float minutes;
    private float milliseconds;
    private float seconds;

    [SerializeField]
    private Text counterText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)(Time.timeSinceLevelLoad / 60f) % 60;
        milliseconds = (int)(Time.timeSinceLevelLoad * 1000f) % 1000;
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        counterText.text = minutes.ToString() + ":" + seconds.ToString() + ":" + milliseconds.ToString();

    }
}
