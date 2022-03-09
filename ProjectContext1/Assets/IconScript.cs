using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconScript : MonoBehaviour
{
    private bool isDragging;

    public float grabOffset = 0f;

    public GameObject program;

    public void OnMouseDown()
    {
        isDragging = true;
        program.transform.position = new Vector3(program.transform.position.x, program.transform.position.y, 1);
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(new Vector2(mousePosition.x, mousePosition.y + grabOffset));
        }
    }
}
