using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisStudioCode : MonoBehaviour
{
    private bool inProgram = false;
    
    public void OnMouseEnter()
    {
        inProgram = true;
    }

    public void OnMouseExit()
    {
        inProgram = false;
    }

    private void Update()
    {
        if (inProgram && Input.GetKeyDown(";") && !GameDirectorScript.fixedCode)
        {
            Debug.Log("; Placed");
            GameDirectorScript.fixedCode = true;
        }
    }
}
