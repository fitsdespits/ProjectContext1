using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkButton : MonoBehaviour
{
    public GameObject program;
    public void OnMouseDown()
    {
        program.gameObject.SetActive(false);
    }
}
