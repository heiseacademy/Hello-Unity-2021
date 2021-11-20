using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMaus : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Maus gedrückt");
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("Objekt wurde mit rechter Maustaste angeklickt.");
        }
    }



    public void OnMouseUpAsButton()
    {
       Debug.Log("Objekt angeklickt!");
    }
}
