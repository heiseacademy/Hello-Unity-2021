using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloDuplicate : MonoBehaviour
{
    public GameObject original;

    //private GameObject kopie;

    private void OnEnable()
    {
        Debug.Log("Enabled!");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled!");
    }



    private void OnMouseUp()
    {
        GameObject kopie = GameObject.Find("Capsule(Clone)");

        if (kopie != null)
        {
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            {
                kopie.SetActive(!kopie.activeSelf);
            }
            else
            {
                Destroy(kopie);
                if (kopie == null) Debug.Log("Kopie ist nach Destroy null.");
                else Debug.Log("Kopie ist nach Destroy NICHT null.");
            }
        }
        else 
        {
            kopie = Instantiate(original);
            kopie.transform.position += new Vector3(1.5f, 0f, 0f);
        }
    }
}
