using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButton : MonoBehaviour
{
    public GameObject buttonTransform;

    void OnEnable()
    {
        buttonTransform.gameObject.SetActive(true);
    }
}
