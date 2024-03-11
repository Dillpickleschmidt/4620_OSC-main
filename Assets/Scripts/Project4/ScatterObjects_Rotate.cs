using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterObjects : MonoBehaviour
{
    [SerializeField] float scatterRadius = 5.0f;
    List<GameObject> objectsList = new List<GameObject>();
    List<float> rotationSpeeds = new List<float>(); // List of rotation speeds
    [SerializeField] float globalRotationSpeed = 1.0f;
    [SerializeField] int numberOfObjects = 10;
    Vector3 rotationPoint = Vector3.zero; // The point around which the objects will rotate

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.position = Random.insideUnitSphere * scatterRadius;
        // Randomize the scale of the object
        float randomScaleX = Random.Range(0.02f, 0.5f);
        float randomScaleY = Random.Range(0.02f, 0.5f);
        float randomScaleZ = Random.Range(0.02f, 0.5f);
        obj.transform.localScale = new Vector3(randomScaleX, randomScaleY, randomScaleZ);
        objectsList.Add(obj);

        // Set a random rotation speed for this object
        rotationSpeeds.Add(Random.Range(5f, 50f) * globalRotationSpeed); // Most objects rotate at a slow speed
        if (i % 5 == 0) // Every 5th object
        {
            rotationSpeeds[i] *= 5f; // Increase the rotation speed for a few objects
        }
    }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < objectsList.Count; i++)
        {
            // Calculate the new position of the object after rotation
            objectsList[i].transform.position = RotatePointAroundPivot(objectsList[i].transform.position, rotationPoint, new Vector3(0, rotationSpeeds[i] * Time.deltaTime, 0));
        }
    }

    // This method returns a new position for 'point' after rotation of 'angle' around 'pivot'
    Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle)
    {
        Vector3 dir = point - pivot; // get point direction relative to pivot
        dir = Quaternion.Euler(angle) * dir; // rotate it
        point = dir + pivot; // calculate rotated point
        return point; // return it
    }
}