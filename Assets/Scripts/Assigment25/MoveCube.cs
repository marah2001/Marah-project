using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float moveDistance = 2f; // المسافة التي سيتحركها المكعب
    private Vector3 originalPosition; // حفظ الموضع الأصلي للمكعب

    void Start()
    {
        originalPosition = transform.position; // حفظ الموضع الأصلي عند بدء المشهد
    }

    void OnMouseDown()
    {
        if (transform.position.x == originalPosition.x)
        {
            // إذا كان المكعب في موضعه الأصلي، حركه لليسار
            transform.position -= new Vector3(moveDistance, 0, 0);
        }
        else
        {
            // إذا كان المكعب قد تحرك، عيده إلى موضعه الأصلي
            transform.position = originalPosition;
        }
    }
}
