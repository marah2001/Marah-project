using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBox : MonoBehaviour
{
    public float openSpeed = 2f; 
    public float closedHeight = -0.5f; 
    public float openedHeight = 1f; 
    private bool isOpened = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isOpened = !isOpened; 
        }

        float targetHeight = isOpened ? openedHeight : closedHeight; 
        float currentHeight = transform.position.y;

        float step = openSpeed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, 
                                                new Vector3(transform.position.x, targetHeight, transform.position.z), 
                                                step);
    }
}
