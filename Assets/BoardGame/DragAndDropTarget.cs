using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropTarget : MonoBehaviour
{
    [SerializeField] SpriteRenderer highlight;
    private void OnMouseEnter()
    {
        if(highlight!=null)
        highlight.enabled = true;
    }

    private void OnMouseExit()
    {
        if (highlight != null)

            highlight.enabled = false;

    }

    Vector2 cardStartPos;
    Vector2 cardClickedAtPos;


    private void OnMouseDown()
    {
        cardClickedAtPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cardStartPos = transform.position;
        
    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 offsetVector = mousePosition - cardClickedAtPos;
        transform.position = cardStartPos + offsetVector;
    }

    private void OnMouseUp()
    {
        
    }
}
