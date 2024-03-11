using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor1 : MonoBehaviour
{
    public Transform oscObj;
    Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current color
        Color currentColor = mat.color;

        // Convert the current color to HSV
        Color.RGBToHSV(currentColor, out float h, out float s, out float v);

        // Modify the hue component based on the position of the oscObj
        h += oscObj.position.x * 0.005f; // Adjust the multiplier for slower hue shift

        // Ensure hue stays within the range [0, 1]
        h = Mathf.Repeat(h, 0.5f);

        // Convert back to RGB
        Color newColor = Color.HSVToRGB(h, s, v);

        // Update the material color
        mat.color = newColor;
    }
}
