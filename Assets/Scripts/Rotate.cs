using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform oscObj;
    float accumRotationZ = 0f;

    // Update is called once per frame
    void Update()
    {
        // Increment the accumulated rotation around the x-axis based on the position of oscObj
        accumRotationZ += oscObj.position.x * Time.deltaTime * 45f; // Adjust the rotation speed as needed

        // Apply the accumulated rotation to the object
        transform.rotation = Quaternion.Euler(0f, 0f, accumRotationZ);
    }
}
