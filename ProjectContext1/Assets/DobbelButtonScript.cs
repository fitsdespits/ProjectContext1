using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobbelButtonScript : MonoBehaviour
{
    private bool hasClicked = false;
    private bool nowThrowing = false;

    public GameObject dobbelError;
    public GameObject marker;
    public bool markerDone = false;

    public GameObject dobbel1, dobbel2, dobbel3, dobbel4, dobbel5, dobbel6;

    public float timer;

    public void OnMouseDown()
    {
        hasClicked = true;
    }

    public void OnMouseUp()
    {
        hasClicked = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (GameDirectorScript.fixedCode && hasClicked && !nowThrowing)
        {
            nowThrowing = true;

            if (!markerDone)
            {
                marker.gameObject.SetActive(false);
                markerDone = true;
            }
        }

        if (!GameDirectorScript.fixedCode && hasClicked && !nowThrowing)
        {
            Debug.Log("Opening " + dobbelError.gameObject.name);
            dobbelError.gameObject.SetActive(true);
            dobbelError.transform.position = new Vector3(0, 0, 0);
        }

        //TIMER

        if (nowThrowing)
        {
            timer += 1 * Time.deltaTime;
        }

        //SECRET CODE
        if (timer > 0)
        {
            dobbel5.gameObject.SetActive(true); //5
        }

        if (timer > 1)
        {
            dobbel5.gameObject.SetActive(false);
            dobbel4.gameObject.SetActive(true); //4
        }

        if (timer > 2)
        {
            dobbel4.gameObject.SetActive(false);
            dobbel2.gameObject.SetActive(true); //2
        }

        if (timer > 3)
        {
            dobbel2.gameObject.SetActive(false);
            dobbel6.gameObject.SetActive(true); //6
        }

        if (timer > 4)
        {
            dobbel6.gameObject.SetActive(false);
            nowThrowing = false;
            timer = 0;
        }

    }
}
