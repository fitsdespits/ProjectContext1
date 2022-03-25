using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBoxArtTimer : MonoBehaviour
{
    public GameObject program;
    public float offset = 1;
    public void OnMouseDown()
    {
        program.gameObject.SetActive(true);
        program.transform.position = new Vector3(0, offset, 0);
    }
}
