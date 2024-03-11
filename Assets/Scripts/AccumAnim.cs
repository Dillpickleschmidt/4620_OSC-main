using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumAnim : MonoBehaviour
{
    public Transform oscObj;
    float accum;
    [Range (0,0.1f)]
    [SerializeField] float accumSpeed = 0.001f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accum += oscObj.position.x * accumSpeed;
        transform.position = new Vector3(Mathf.Cos(accum), 0, Mathf.Sin(accum));
    }
}
