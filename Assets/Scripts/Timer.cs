using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeToWait = 5.0f; // the time to wait before changing scenes in seconds
    private float timer = 0.0f; // the current timer value
    private bool timerStarted = false; // flag to track whether the timer has been started

    // Start is called before the first frame update
    void Start()
    {
        timer = timeToWait; // initialize the timer value to the time to wait
        timerStarted = true; // set the flag to true so the timer will start
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            timer -= Time.deltaTime; // decrement the timer value each frame
           // if (timer <= 0.0f)
            //{
           //     SceneManager.LoadScene("SceneName"); // change scenes when the timer ends
            //}
        }
    }
}
