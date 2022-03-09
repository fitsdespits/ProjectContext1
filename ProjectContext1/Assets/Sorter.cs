using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorter : MonoBehaviour
{
    private GameObject[] programs;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            programs = GameObject.FindGameObjectsWithTag("Program");

            foreach(GameObject p in programs)
                p.transform.position = new Vector3(p.transform.position.x,p.transform.position.y,p.transform.position.z + 5);
        }   
    }
}
