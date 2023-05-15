using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    void Start()
    {
        
    }

    Item dragTarget;
    void Update()
    {
        MouseDragItem();

    }

    private void MouseDragItem()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D target = Physics2D.OverlapCircle(mousePos, 0.1f);
            if (target != null && target.TryGetComponent(out dragTarget))
            {
                dragTarget.Draging(true);
            }
        }
        if (dragTarget != null && Input.GetMouseButtonUp(0))
        {
            dragTarget.Draging(false);
            dragTarget = null;
        }
        if (dragTarget != null)
        {
            dragTarget.transform.position = mousePos;
        }
    }
}
