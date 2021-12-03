using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFlackern : MonoBehaviour
{
    public Light licht;

    private Color von = Color.HSVToRGB(0f,1f,1f);
    private Color bis = Color.HSVToRGB(60f/360f, 1f, 1f);
    private float prozent = 0f;

    public float dauer = 0.5f;

    private void Update()
    {
        prozent += Time.deltaTime / dauer;
        licht.color = Color.Lerp(von,bis,prozent);

        if (prozent>=1f)
        {
            von = bis;
            bis = Random.ColorHSV(0,60f/360f,0.9f,1f, 0.7f,1.0f);
            prozent = 0f;
        }
    }
}
