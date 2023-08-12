using System.Collections;
using UnityEngine;

public class LightningStrike : MonoBehaviour
{
    public float strikeInterval = 5f; // Time between lightning
    public float flashDuration = 0.1f; // Duration of the lightning flash
    public GameObject dLight; // directional Lighting

    private Light lightSource;

    private void Start()
    {
        lightSource = dLight.GetComponent<Light>();
        StartCoroutine(LightningEffect());
    }

    private IEnumerator LightningEffect()
    {
        while (true)
        {
            yield return new WaitForSeconds(strikeInterval);

            // Start the lightning flash
            lightSource.color = Color.white;

            yield return new WaitForSeconds(flashDuration);

            // End the lightning flash
            lightSource.color = new Color(0.377f, 0.377f, 0.377f);
        }
    }
}

