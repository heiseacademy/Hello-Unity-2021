using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloiTween : MonoBehaviour
{
    public Transform von;
    public Transform bis;
    public float dauerInSekunden = 3f;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = von.position;
        //iTween.MoveTo(gameObject, bis.position, dauerInSekunden);
        iTween.MoveTo(gameObject, iTween.Hash("position",bis, "time",dauerInSekunden, "easeType",iTween.EaseType.spring));
    }

}
