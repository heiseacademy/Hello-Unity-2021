using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloRotation : MonoBehaviour
{
    public Vector3 drehung;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(drehung * Time.deltaTime);
    }
}
