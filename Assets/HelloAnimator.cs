using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloAnimator : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
            animator.SetTrigger("wechseln");
        else if (Input.GetKeyUp(KeyCode.D))
            animator.SetInteger("zahl", 1);
        else if (Input.GetKeyUp(KeyCode.A))
            animator.SetInteger("zahl", -1);
    }
}
