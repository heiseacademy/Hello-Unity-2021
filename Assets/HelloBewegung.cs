using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloBewegung : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45f, 0, 0) * Time.deltaTime);

        // Input.GetKey(KeyCode.W))
        transform.position += new Vector3(1 * Input.GetAxisRaw("Horizontal"), 0, 0) * Time.deltaTime;
    }

    public void OnMouseUp()
    {
        Debug.Log("Suche nach SphereCollider="+FindObjectOfType<SphereCollider>().gameObject.name);

        CapsuleCollider cc = GetComponent<CapsuleCollider>();
        if (cc!=null)
        {
            cc.enabled = false; // !cc.enabled;
        }
    }
}
