using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 laufweite = new Vector3(1f, 0f, 0f);
        //transform.position += laufweite;
        Vector3 p = transform.position;
        p.x = 5f;
        transform.position = p;
        Debug.Log(this.gameObject.name + " steht bei: "+transform.position+", relativ: "+transform.localPosition);

        Debug.Log(this.gameObject.name + " hat die Skalierung: " + transform.lossyScale + ", relativ: " + transform.localScale);
        Debug.Log("Wert direkt: " + transform.lossyScale.x);

        Debug.Log(this.gameObject.name + " hat die Drehung: " + transform.rotation.eulerAngles + ", relativ: " + transform.localRotation.eulerAngles);

        Quaternion r = transform.rotation;
        r.eulerAngles += new Vector3(10f,0f,0f);
        transform.rotation = r;

        Debug.Log("Elternobjekt heiﬂt: "+transform.parent.name);
        transform.SetParent(null);

        //new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
