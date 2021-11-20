using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloLerp : MonoBehaviour
{
    public Transform von;
    public Transform bis;
    private float gelaufeneZeit = 0f;

    public float dauerInSekunden = 3f;

    void Update()
    {
        transform.position = Vector3.Lerp(von.position, bis.position, gelaufeneZeit );
        gelaufeneZeit += Time.deltaTime / dauerInSekunden; //3=dauer in Sekunden
    }
}
