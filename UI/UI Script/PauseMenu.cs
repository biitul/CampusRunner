using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PausePage;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused) 
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    public void Play()
    {
        PausePage.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void Stop()
    {
        PausePage.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
