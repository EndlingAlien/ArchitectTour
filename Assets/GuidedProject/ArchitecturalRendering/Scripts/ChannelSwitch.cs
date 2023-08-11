using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelSwitch : MonoBehaviour
{
    public float switchInterval = 8f; // Time between switch
    public float minActiveTime = 1f; // Minimum time the channel stays active
    public float maxActiveTime = 2.5f; // Maximum time the channel stays active

    public GameObject sChannel; //spooky channel
    public GameObject nChannel; //normal static
    private float nextSwitchTime;
    private bool isSwitching;

    private void Start()
    {

        isSwitching = false;
        SetNextSwitchTime();
    }

    private void Update()
    {


        if (Time.time >= nextSwitchTime)
        {
            if (isSwitching)
            {
                sChannel.SetActive(false);
                nChannel.SetActive(true);
                isSwitching = false;
                SetNextSwitchTime();
            }
            else
            {
                sChannel.SetActive(true);
                nChannel.SetActive(false);
                isSwitching = true;
                SetNextSwitchTime();
            }
        }
    }

    private void SetNextSwitchTime()
    {
        nextSwitchTime = Time.time + Random.Range(minActiveTime, maxActiveTime + switchInterval);
    }
}
