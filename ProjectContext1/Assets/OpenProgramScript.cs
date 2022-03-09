using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProgramScript : MonoBehaviour
{
    private int clicks = 0;

    private int doubleClickTimer = 0;

    private int timeLimit = 150;

    private bool isDragging;

    public GameObject program;
    void Awake()
    {
        program.gameObject.SetActive(false);
    }

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clicks >= 1 && isDragging)
        {
            DoubleClick();
        }

        if (Input.GetMouseButtonDown(0))
        {
            clicks += 1;
        }

        if(clicks >= 1)
        {
            doubleClickTimer += 1;
        }

        if(doubleClickTimer >= timeLimit)
        {
            clicks = 0;
            doubleClickTimer = 0;
        }
    }
    void DoubleClick()
    {
        Debug.Log("Opening ", program);
        program.gameObject.SetActive(true);
    }
}

