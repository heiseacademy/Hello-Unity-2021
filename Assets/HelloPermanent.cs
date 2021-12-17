using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloPermanent : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
