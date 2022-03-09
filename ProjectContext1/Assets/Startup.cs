using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{

    public GameObject program;

    void Start()
    {
        program.gameObject.SetActive(false);
    }

}
