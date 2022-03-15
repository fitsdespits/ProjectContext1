using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginScreen : MonoBehaviour
{
    public GameObject desktop;
    public GameObject login;
    public void OnMouseDown()
    {
        Debug.Log("Opening " + desktop.gameObject.name);
        desktop.gameObject.SetActive(true);
        login.gameObject.SetActive(false);
    }
}
