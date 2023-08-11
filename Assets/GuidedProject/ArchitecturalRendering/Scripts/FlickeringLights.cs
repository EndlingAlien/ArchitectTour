using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{
    public float flickerInterval = 0.3f; // Time between flickers
    public float minActiveTime = 0.2f; // Minimum time the light stays active
    public float maxActiveTime = 0.5f; // Maximum time the light stays active

    public GameObject flickeringObject;
    private float nextFlickerTime;
    private bool isFlickering;

    private void Start()
    {

        isFlickering = false;
        SetNextFlickerTime();
    }

    private void Update()
    {


        if (Time.time >= nextFlickerTime)
        {
            if (isFlickering)
            {
                flickeringObject.SetActive(false); // Deactivate the GameObject
                isFlickering = false;
                SetNextFlickerTime();
            }
            else
            {
                flickeringObject.SetActive(true); // Activate the GameObject
                isFlickering = true;
                SetNextFlickerTime();
            }
        }
    }

    private void SetNextFlickerTime()
    {
        nextFlickerTime = Time.time + Random.Range(minActiveTime, maxActiveTime + flickerInterval);
    }
}
