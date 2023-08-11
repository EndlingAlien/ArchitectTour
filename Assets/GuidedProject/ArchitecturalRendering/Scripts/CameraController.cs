using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    public Button camera1Label;
    public Button camer2Label;
    public Button camera3Label;
    public Button Camera4Label;

    public GameObject player;

    //this script will trigger the cameras when the player enters
    //their respective areas, as well as activate the correct label
    //of camera on the overlay when switched over
    //when main cam is active security overlay is not
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
