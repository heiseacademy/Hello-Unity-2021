using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kameraverhalten : MonoBehaviour
{
    public Renderer r;
    private Material altesMaterial;
    public Material neuesMaterial;

    private void Start()
    {
        altesMaterial = r.sharedMaterial;
    }

    public Transform ziel;

    private void Update()
    {
        float distanz = Vector3.Distance(transform.position, ziel.position);
        if (distanz <= 3f)
        {
            Vector3 richtungZumZiel = ziel.position - transform.position;
            float winkelZumZiel = Vector3.Angle(transform.right, richtungZumZiel);
            if (winkelZumZiel < 90f / 2f)
            {
                r.sharedMaterial = neuesMaterial;
            }
            else r.sharedMaterial = altesMaterial;
        }
        else
            r.sharedMaterial = altesMaterial;
        
    }
}
