using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
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
        mat.color = new Color(oscObj.position.x, oscObj.position.x, oscObj.position.x)*0.1f;
    }
}
