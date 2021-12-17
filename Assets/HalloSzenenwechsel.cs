using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalloSzenenwechsel : MonoBehaviour
{
    public string zielszene;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            SceneManager.LoadScene(zielszene);
    }
}
