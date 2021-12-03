using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFirstPerson : MonoBehaviour
{
    public Transform kopf;
    private float gierWinkel = 0f;
    private float nickWinkel = 0f;


    // Update is called once per frame
    void Update()
    {
        float horz = Input.GetAxis("Mouse X") * Time.deltaTime * 180f;
        float vert = Input.GetAxis("Mouse Y") * Time.deltaTime * 180f;

        gierWinkel += horz;
        nickWinkel += vert;


        transform.localRotation = Quaternion.AngleAxis(gierWinkel, Vector3.up) * Quaternion.identity;
        kopf.localRotation = Quaternion.AngleAxis(nickWinkel, Vector3.right) * Quaternion.identity;
    }
}
