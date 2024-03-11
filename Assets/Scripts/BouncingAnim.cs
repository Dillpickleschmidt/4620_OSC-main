using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingAnim : MonoBehaviour
{
    public Transform oscOBJ;
    private float multiplier;

    void Start()
    {
        // Initialize multiplier with a random value between 0 and 1
        UpdateMultiplier();
    }

    // Update is called once per frame
    void Update()
    {
        // Update multiplier every second
        if (Time.time % 1.0f < Time.deltaTime)
        {
            UpdateMultiplier();
        }

        // Apply animation using the updated multiplier
        float adsr = oscOBJ.position.x * multiplier;
        transform.position = new Vector3(0, 1 - adsr, 0);
    }

    // Method to update the multiplier with a random value between 0 and 1
    void UpdateMultiplier()
    {
        multiplier = Random.Range(0.001f, .2f);
    }
}
