using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showCanvas : MonoBehaviour
{
    public Button button; // Reference to the button
    public GameObject canvas; // Reference to the canvas

    void Start()
    {
        // Ensure the canvas is hidden at the start
        canvas.SetActive(false);

        // Add a listener to the button to trigger when clicked
        button.onClick.AddListener(ShowCanvas);

        
    }

    void ShowCanvas()
    {
        // Make the canvas visible when the button is pressed
        canvas.SetActive(true);
    }
}
