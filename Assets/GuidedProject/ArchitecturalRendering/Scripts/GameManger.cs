using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private bool isBtnClicked;
    public GameObject fadeOverlay;
    private Animator fadeAnim;
    public float waitDelay = 2f;

    public CameraController cameraController;
    public GameObject gameManger;
    public GameObject menuCam;
    public GameObject menuAudio;
    public GameObject houseAudio;
    public GameObject securityOverlay;
    public GameObject outsideEnvironment;


    // Start is called before the first frame update
    void Start()
    {
        fadeAnim = fadeOverlay.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBtnClicked)
        {
            Debug.Log("started scene transistion");
            SceneTransition();
        }
    }

    public void ClickButton()
    {
        Debug.Log("Button was clicked");
        isBtnClicked = true;
    }

    public void SceneTransition()
    {
        fadeOverlay.SetActive(true);
        fadeAnim.SetTrigger("FadeOut");
        Debug.Log("starting anim");
        StartCoroutine(LoadCam());
    }

    private IEnumerator LoadCam()
    {
        Debug.Log("starting timer");
        //// Wait for a brief moment while the animations play
        yield return new WaitForSecondsRealtime(waitDelay);

        Debug.Log("setting objects");
        cameraController.SwitchToCamera(1);
        cameraController.SwitchToLabel(1);
        menuCam.SetActive(false);
        menuAudio.SetActive(false);
        houseAudio.SetActive(true);
        securityOverlay.SetActive(true);
        fadeOverlay.SetActive(false);
        gameManger.SetActive(false);
        outsideEnvironment.SetActive(false);
        isBtnClicked = false;
    }


}
