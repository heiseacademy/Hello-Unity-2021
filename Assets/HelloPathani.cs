using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloPathani : MonoBehaviour
{
    public float dauer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "path", iTweenPath.GetPath("pfad1"),
            "time", dauer,
            "easetype", iTween.EaseType.linear,
            "looptype", iTween.LoopType.loop            
            ));
    }

}
