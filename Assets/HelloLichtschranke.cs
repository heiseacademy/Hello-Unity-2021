using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloLichtschranke : MonoBehaviour
{
    public Camera kamera1;
    public Camera kamera2;

    private void OnTriggerEnter(Collider other)
    {
        kamera1.enabled = false;
        kamera2.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        kamera1.enabled = true;
        kamera2.enabled = false;
    }

}
