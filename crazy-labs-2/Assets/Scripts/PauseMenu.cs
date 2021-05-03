using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject settingsMenu;
    public Movement movement;
    public GameObject playerReference;
    AudioSource audioSource;

    void Start()
    {
        Resume();
        audioSource = GetComponent<AudioSource>();
        

    }
    public void Update()
    {
        //movement = GetComponent<Movement>();
        
    }

    public void Pause ()
    {
        
        pauseButton.SetActive(false);
        settingsMenu.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        settingsMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Quit ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Settings ()
    {
        pauseMenuUI.SetActive(false);
        settingsMenu.SetActive(true);
        Time.timeScale = 0f;      
    }

    public void backButton ()
    {
        Pause();
    }

    public void easyGame ()
    {

        movement.forwardsSpeed = 15f;
    }

    public void normieGame ()
    {
        movement.forwardsSpeed = 25f;
    }

    public void crazyGame ()
    {
        movement.forwardsSpeed = 45f;
    }

    public void offSFX ()
    {
        playerReference.GetComponent<AudioSource>().volume = 0f;
    }

    public void onSFX ()
    {
        playerReference.GetComponent<AudioSource>().volume = 1f;
    }

}
