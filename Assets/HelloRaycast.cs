using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloRaycast : MonoBehaviour
{
    private void Update()
    {
        Vector3 von = transform.position;
        Vector3 richtung = -transform.up;

        if (Physics.Raycast(von, richtung, 1f))
            Debug.DrawRay(von, richtung, Color.red);
        else
            Debug.DrawRay(von, richtung, Color.blue);
    }
}
