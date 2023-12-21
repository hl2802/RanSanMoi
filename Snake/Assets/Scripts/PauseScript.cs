using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{

    public Text pauseText;

    void Start()
    {
        pauseText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            // Game is not paused
            Time.timeScale = 0;             // Pause the game
            pauseText.gameObject.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            // Game is paused
            Time.timeScale = 1;             // Continue the game
            pauseText.gameObject.SetActive(false);
        }
    }
}
