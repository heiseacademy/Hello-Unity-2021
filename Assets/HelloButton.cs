using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloButton : MonoBehaviour
{
    public GameObject menuRoot;

    public void Start()
    {
        menuRoot.SetActive(false);
    }

    public void MenueUmschalten()
    {
        Debug.Log("Angeklickt");
        menuRoot.SetActive(!menuRoot.activeSelf);
    }
}
