using UnityEngine;

public class Scale : MonoBehaviour
{
    public Transform oscObj; // Object whose transform will be read
    public float minYScale = 5f; // Minimum y scale
    public float maxYScale = 10.0f; // Maximum y scale

    // Update is called once per frame
    void Update()
    {
        if (oscObj == null)
            return;

        // Read the value from the input (assuming it ranges from 0 to 10)
        float inputValue = Mathf.Clamp(oscObj.localPosition.x, 0f, 10f);

        // Map the input value to the range between minYScale and maxYScale
        float mappedValue = Remap(inputValue, 0f, 10f, minYScale, maxYScale);

        // Apply the mapped value to the object's scale
        transform.localScale = new Vector3(transform.localScale.x, mappedValue, transform.localScale.z);
    }

    // Function to remap a value from one range to another
    float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
}
