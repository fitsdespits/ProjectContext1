using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    private bool hasPopped = false;
    public GameObject popUp;
    
    void OnMouseOver()
    {
        if (!hasPopped)
        {
            Debug.Log("Opening " + popUp.gameObject.name);
            popUp.gameObject.SetActive(true);
            popUp.transform.position = new Vector3(-4, -1, 0);
            hasPopped = true;
        }
    }
}
