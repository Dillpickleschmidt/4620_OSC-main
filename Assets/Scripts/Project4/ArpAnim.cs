using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArpAnim : MonoBehaviour
{
    // Public Transform variable to assign our oscOBJ through the Unity Editor
    public Transform oscOBJ;

    // Public float variable to set an offset for the y translation
    public float yOffset = 0f;

    public float multiplier = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Getting the current x position of oscOBJ
        float oscOBJXPosition = oscOBJ.position.x * multiplier;
        
        // Applying the oscOBJ's x position to this object's y position with an offset, while keeping its own x and z positions
        transform.position = new Vector3(transform.position.x, oscOBJXPosition + yOffset, transform.position.z);
    }
}
