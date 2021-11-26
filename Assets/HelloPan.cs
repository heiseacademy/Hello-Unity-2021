using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloPan : MonoBehaviour
{
    private Vector3 dragOrigin;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (!Physics.Raycast(ray, out hit)) return;

            if (Input.GetMouseButtonDown(0))
                dragOrigin = hit.point;

            Vector3 diff = dragOrigin - hit.point;
            Camera.main.transform.position += diff;

        }
    }
}
