using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAnim : MonoBehaviour
{
    public Vector3 pointToRevolveAround = Vector3.zero; // The point around which the object will revolve.
    public Vector3 rotationAxis = Vector3.up; // The axis around which the object will rotate. Default is up.
    public float speed = 10f; // Speed of rotation.
    public float radius = 5f; // Distance from the point to revolve around.

    private void Start()
    {
        // Set the initial position of the object at the start based on the radius.
        SetInitialPosition();
    }

    private void Update()
    {
        // Rotate around the point at a certain speed.
        transform.RotateAround(pointToRevolveAround, rotationAxis, speed * Time.deltaTime);
    }

    private void SetInitialPosition()
    {
        // Calculate the initial position based on the given radius. This example assumes rotation around a vertical axis.
        // For different axes, you might need to adjust the logic here.
        Vector3 direction = (transform.position - pointToRevolveAround).normalized;
        transform.position = pointToRevolveAround + direction * radius;
    }
}
