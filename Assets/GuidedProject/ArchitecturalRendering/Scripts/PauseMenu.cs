using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameManager;
    public GameObject menuCam;
    public GameObject menuAudio;
    public GameObject houseAudio;
    public GameObject securityOverlay;
    public GameObject outsideEnvironment;
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu.SetActive(true);
            securityOverlay.SetActive(false);
            Time.timeScale = 0f;
        }


    }


    public void ExitButtonwasClicked()
    {
        securityOverlay.SetActive(true);
        Time.timeScale = 1f;
    }

    public void MenuButtonWasClicked()
    {
        gameManager.SetActive(true);
        menuCam.SetActive(true);
        menuAudio.SetActive(true);
        houseAudio.SetActive(false);
        securityOverlay.SetActive(false);
        outsideEnvironment.SetActive(true);
        mainMenu.SetActive(true);
    }
}
