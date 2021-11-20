using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloForces : MonoBehaviour
{
    private Rigidbody[] rbs;

    private void Start()
    {
        rbs = FindObjectsOfType<Rigidbody>();
    }

    private float stossImpuls = 0f;
    private float drehImpuls = 0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) stossImpuls = 3f;
        if (Input.GetMouseButtonDown(1)) drehImpuls = 2f;
    }

    private void FixedUpdate()
    {
        foreach(Rigidbody rb in rbs)
        {
            if (rb.isKinematic) continue;
            Vector3 richtung = rb.transform.position - transform.position;
            rb.AddForce(richtung * stossImpuls, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * drehImpuls, ForceMode.Impulse);
        }

        stossImpuls = 0f;
        drehImpuls = 0f;
    }
}
