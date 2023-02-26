using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Reference to the TextMeshProUGUI component
    public float timerDuration = 60.0f;  // Duration of the timer in seconds
    public string nextSceneName;  // Name of the next scene to load after the timer ends

    private float timer;  // Current time left on the timer

    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer
        timer -= Time.deltaTime;

        // Update the timer text
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer % 60.0f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Check if the timer has ended
        if (timer <= 0.0f)
        {
            // Load the next scene
           UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        }
    }
}
