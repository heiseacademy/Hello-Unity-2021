using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{
    public Renderer r;
    private void OnMouseUpAsButton()
    {
        Vector2 xy = r.material.mainTextureOffset;
        xy.x += 0.25f;
        r.material.mainTextureOffset = xy;
    }

}
