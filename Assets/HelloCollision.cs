using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCollision : MonoBehaviour
{
    private Renderer r;
    private Material altesMaterial;
    public Material neuesMaterial;

    // Start is called before the first frame update
    private void Start()
    {
        r = GetComponent<Renderer>();
        altesMaterial = r.sharedMaterial;
    }

    private void OnCollisionEnter(Collision collision)
    {
        r.sharedMaterial = neuesMaterial;
    }

    private void OnCollisionStay(Collision collision)
    {
        r.sharedMaterial = neuesMaterial;
    }


    private void OnCollisionExit(Collision collision)
    {
        r.sharedMaterial = altesMaterial;
    }

}
