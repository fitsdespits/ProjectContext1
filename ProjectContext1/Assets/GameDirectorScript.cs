using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirectorScript : MonoBehaviour
{
    public static bool fixedCode = false;
    private bool dobbelStarted = false;

    public GameObject correctCode;
    public GameObject wrongCode;

    private void Update()
    {
        if(fixedCode && !dobbelStarted)
        {
            dobbelStarted = true;
            correctCode.gameObject.SetActive(true);
            wrongCode.gameObject.SetActive(false);
        }
    }
}
