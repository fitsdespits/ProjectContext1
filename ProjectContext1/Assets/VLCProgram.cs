using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VLCProgram : MonoBehaviour
{

    public float timeValue = 0;
    public float limit = 10;
    public bool hasStarted = false;
    public bool end = false;

    public GameObject program;
    
    // Start is called before the first frame update
    public void OnMouseOver()
    {
        if (!hasStarted)
        {
            hasStarted = true;
            Debug.Log("Playing Jeppe's Video");

            //PLAY VIDEO HERE
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted && timeValue < limit & !end)
        {
            timeValue += Time.deltaTime;
        }

        if(hasStarted && timeValue >= limit && !end)
        {
            //EMAIL OPENS
            program.gameObject.SetActive(true);
            program.transform.position = new Vector3(0, 2.5f, 0);
            end = true;
        }
    }
}
