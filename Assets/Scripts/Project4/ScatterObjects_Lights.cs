using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterObjects_Lights : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab; // The object you want to use
    [SerializeField] float scatterRadius = 5.0f;
    List<GameObject> objectsList = new List<GameObject>();
    [SerializeField] int numberOfObjects = 10;
    [SerializeField] float globalRotationSpeed = 1.0f; // Global rotation speed for all objects

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject obj = Instantiate(objectPrefab); // Create an instance of the specified object
            obj.transform.position = Random.insideUnitSphere * scatterRadius;

            // Set a random rotation for the object
            float randomRotationX = Random.Range(0f, 360f);
            float randomRotationY = Random.Range(0f, 360f);
            float randomRotationZ = Random.Range(0f, 360f);
            obj.transform.rotation = Quaternion.Euler(randomRotationX, randomRotationY, randomRotationZ);

            objectsList.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in objectsList)
        {
            // Define a rotation speed
            float rotationSpeed = 20f * globalRotationSpeed;

            // Calculate rotation amount
            float rotationX = rotationSpeed * Time.deltaTime;
            float rotationY = rotationSpeed * Time.deltaTime;
            float rotationZ = rotationSpeed * Time.deltaTime;

            // Apply rotation
            obj.transform.Rotate(rotationX, rotationY, rotationZ);
        }
    }
}