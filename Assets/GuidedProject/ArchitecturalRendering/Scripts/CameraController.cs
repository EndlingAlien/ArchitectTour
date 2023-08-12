using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    public GameObject cam1Label;
    public GameObject cam2Label;
    public GameObject cam3Label;
    public GameObject cam4Label;

    private int cameraNum;


    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(cameraNum == 1);
        cam2.SetActive(cameraNum == 2);
        cam3.SetActive(cameraNum == 3);
        cam4.SetActive(cameraNum == 4);

        cam1Label.SetActive(cameraNum == 1);
        cam2Label.SetActive(cameraNum == 2);
        cam3Label.SetActive(cameraNum == 3);
        cam4Label.SetActive(cameraNum == 4);
    }

    public void SwitchToCamera(int cameraNum)
    {
        Debug.Log("Switching to camera: " + cameraNum);
        //cameraNum = newCameraNum;

        switch (cameraNum)
        {
            case 1:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                break;
            case 2:
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                cam4.SetActive(false);
                break;
            case 3:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                cam4.SetActive(false);
                break;
            case 4:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(true);
                break;
            default:
                cam1.SetActive(true);
                break;
        }
    }

    public void SwitchToLabel(int cameraNum)
    {
        Debug.Log("Switching to cameraLabel: " + cameraNum);

        switch (cameraNum)
        {
            case 1:
                cam1Label.SetActive(true);
                cam2Label.SetActive(false);
                cam3Label.SetActive(false);
                cam4Label.SetActive(false);
                break;
            case 2:
                cam1Label.SetActive(false);
                cam2Label.SetActive(true);
                cam3Label.SetActive(false);
                cam4Label.SetActive(false);
                break;
            case 3:
                cam1Label.SetActive(false);
                cam2Label.SetActive(false);
                cam3Label.SetActive(true);
                cam4Label.SetActive(false);
                break;
            case 4:
                cam1Label.SetActive(false);
                cam2Label.SetActive(false);
                cam3Label.SetActive(false);
                cam4Label.SetActive(true);
                break;
            default:
                cam1Label.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SwitchToCamera(1);
            SwitchToLabel(1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            SwitchToCamera(2);
            SwitchToLabel(2);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SwitchToCamera(3);
            SwitchToLabel(3);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            SwitchToCamera(4);
            SwitchToLabel(4);
        }
    }

}
