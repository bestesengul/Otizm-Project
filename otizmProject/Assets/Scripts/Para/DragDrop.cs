using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZcoord;

    private void OnMouseDown()
    {
        mZcoord = Camera.main.WorldToScreenPoint(transform.position).z;
        mOffset = transform.position - GetMouseWorldPos();
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
    private Vector3 GetMouseWorldPos()
    {
        // pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZcoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseUp()
    {
        if (this.GetComponent<Rigidbody>())
            this.GetComponent<Rigidbody>().isKinematic = false;
    }
}
