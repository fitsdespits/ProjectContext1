using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{

    public GameObject buttonSelected;
    public GameObject buttonUnselected;

    public GameObject program;

    private bool selected;

    // Start is called before the first frame update
    void OnEnable()
    {
        buttonSelected.gameObject.SetActive(false);
        buttonUnselected.gameObject.SetActive(true);
    }
    public void OnMouseEnter()
    {
        buttonSelected.gameObject.SetActive(true);
        buttonUnselected.gameObject.SetActive(false);
        selected = true;
    }

    public void OnMouseExit()
    {
        buttonSelected.gameObject.SetActive(false);
        buttonUnselected.gameObject.SetActive(true);
        selected = false;
    }

    private void Update()
    {
        if (selected && Input.GetMouseButtonDown(0))
        {
            buttonSelected.gameObject.SetActive(false);
            buttonUnselected.gameObject.SetActive(false);
            selected = false;
            Debug.Log("Closing " + program.gameObject.name);
            program.gameObject.SetActive(false);
        }
    }
}
