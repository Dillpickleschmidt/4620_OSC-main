using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordsColor : MonoBehaviour
{
    // Public Transform variable to use as input
    public Transform oscOBJ;

    // Reference to the Renderer to change its material color
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Renderer component from the GameObject this script is attached to
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ensure the renderer is not null
        if (rend != null)
        {
            // Map the oscOBJ's x position to a value between 0 and 1
            float normalizedPosition = Mathf.Clamp01((oscOBJ.position.x - 0) / (10 - 0));

            // Use the normalized position to interpolate between two colors
            // Change these colors to whatever you prefer
            Color startColor = Color.blue; // Color at the start of the range
            Color endColor = Color.red; // Color at the end of the range
            Color currentColor = Color.Lerp(startColor, endColor, normalizedPosition);

            // Apply the interpolated color to the material
            rend.material.color = currentColor;
        }
    }
}
