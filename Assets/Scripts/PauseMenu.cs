using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public AudioSource pauseAudio;
    public AudioSource unpauseAudio;
    public GameManager gameManager;

    private bool isPaused = false;
    private void Start()
    {
        // Disable the pause menu canvas by default
        pauseMenuCanvas.SetActive(false);
       // gameManager = GetComponent<GameManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            pauseMenuCanvas.SetActive(true);
            pauseAudio.Play();
            Time.timeScale = 0;
            //Debug.Log("UnPause");
            gameManager.canMove = false;
            gameManager.canSwitch = false;

        }
        else
        {
            isPaused = false;
            pauseMenuCanvas.SetActive(false);
            unpauseAudio.Play();
            Time.timeScale = 1;
            //Debug.Log("Pause");
            gameManager.canMove = true;
            gameManager.canSwitch = true;
        }
    }

    public void resume()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseMenuCanvas.SetActive(false);
            unpauseAudio.Play();
            Time.timeScale = 1;
            //Debug.Log("Pause");
            gameManager.canMove = true;
            gameManager.canSwitch = true;
        }
    }

    public void restart()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseMenuCanvas.SetActive(false);
            unpauseAudio.Play();
            Time.timeScale = 1;
            //Debug.Log("Pause");
            gameManager.canMove = true;
            gameManager.canSwitch = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void mainMenu()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseMenuCanvas.SetActive(false);
            unpauseAudio.Play();
            Time.timeScale = 1;
            //Debug.Log("Pause");
            gameManager.canMove = true;
            gameManager.canSwitch = true;
            SceneManager.LoadScene(0);
        }
    }
}
