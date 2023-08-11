using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureGlitch : MonoBehaviour
{
    public float switchInterval = 8f; // Time between glitch
    public float minActiveTime = 1f; // Minimum time the glitch stays active
    public float maxActiveTime = 2.5f; // Maximum time the glitch stays active

    public GameObject glitchingMan;
    private float nextSwitchTime;
    private bool isGlitching;

    private void Start()
    {
        isGlitching = false;
        SetNextSwitchTime();
    }

    private void Update()
    {


        if (Time.time >= nextSwitchTime)
        {
            if (isGlitching)
            {
                glitchingMan.SetActive(false);
                isGlitching = false;
                SetNextSwitchTime();
            }
            else
            {
                glitchingMan.SetActive(true);
                isGlitching = true;
                SetNextSwitchTime();
            }
        }
    }

    private void SetNextSwitchTime()
    {
        nextSwitchTime = Time.time + Random.Range(minActiveTime, maxActiveTime + switchInterval);
    }
}
