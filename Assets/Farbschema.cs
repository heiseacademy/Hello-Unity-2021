using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sonnenfarbschema")]
public class Farbschema : ScriptableObject
{
    public Color sonnenfarbe = Color.white;

    public float intensitaet = 1.0f;
}
