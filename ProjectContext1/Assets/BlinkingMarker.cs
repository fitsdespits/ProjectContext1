using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingMarker : MonoBehaviour
{
    private float timeValue = 0;
    private float limit = 0.7f;
    
    public GameObject marker;
    private bool markerVisible = true;

    // Update is called once per frame
    void Update()
    {
        timeValue += Time.deltaTime;

        if(timeValue >= limit && markerVisible)
        {
            marker.gameObject.SetActive(false);
            markerVisible = false;
            timeValue = 0;
        }

        if (timeValue >= limit && !markerVisible)
        {
            marker.gameObject.SetActive(true);
            markerVisible = true;
            timeValue = 0;
        }
    }
}
