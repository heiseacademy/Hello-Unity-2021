using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloDirection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += -transform.forward * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
