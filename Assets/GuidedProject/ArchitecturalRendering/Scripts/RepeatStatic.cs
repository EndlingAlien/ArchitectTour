using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RepeatStatic : MonoBehaviour
{
    public float speed = 20;
    private Vector2 startPos;
    public float repeatWidth;
    private RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
        repeatWidth = 40;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the UI element to the right
        rectTransform.anchoredPosition += Vector2.right * Time.deltaTime * speed;

        // Check if the UI element is beyond the repeat point
        if (rectTransform.anchoredPosition.x > startPos.x + repeatWidth)
        {
            // Reset the position to create the repeating effect
            rectTransform.anchoredPosition = startPos;
        }
    }
}

