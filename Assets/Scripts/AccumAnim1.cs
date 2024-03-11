using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumAnim1 : MonoBehaviour
{
    public Transform oscObj;
    float accum;
    [Range(0, 0.1f)]
    [SerializeField] float accumSpeed = 0.001f;
    [SerializeField] float scaleFactor = 2.0f; // Adjust this value to set the maximum scale factor
    [SerializeField] float radius = 1.0f; // Set the radius of rotation

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        accum += oscObj.position.x * accumSpeed;

        // Calculate scale between 0.5 and scaleFactor
        float scale = Mathf.Lerp(1f, scaleFactor, (Mathf.Sin(accum) + 1) / 2.0f);
        transform.localScale = new Vector3(scale, scale, scale);

        // Calculate position based on accumulated value and radius
        float x = Mathf.Cos(accum) * radius;
        float z = Mathf.Sin(accum) * radius;
        transform.position = new Vector3(x, 0, z);
    }
}
