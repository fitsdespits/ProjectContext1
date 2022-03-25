using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMarker : MonoBehaviour
{
    public bool markerCleared = false;
    public GameObject marker;
    public void OnMouseDown()
    {
        if (!markerCleared)
        {
            markerCleared = true;
            marker.gameObject.SetActive(false);
        }
    }
}
