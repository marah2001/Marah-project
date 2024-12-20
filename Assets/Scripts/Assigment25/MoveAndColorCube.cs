using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndColorCube : MonoBehaviour
{
    public float moveRightDistance = 2f; 
    public float increaseLength = 0.5f;  
    public float moveForwardDistance = 5f; 
    public Color originalColor; 
    public Color newColor = Color.grey; 

    private Vector3 originalPosition;
    private Vector3 originalScale;

    void Start()
    {
        originalPosition = transform.position;
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position == originalPosition)
            {
               
                transform.position += new Vector3(moveRightDistance, 0, moveForwardDistance);
                transform.localScale += new Vector3(increaseLength, 0, 0);
            }
            else
            {
             
                transform.position = originalPosition;
                transform.localScale = originalScale;
                GetComponent<Renderer>().material.color = newColor;
            }
        }
    }
}

// public class MoveAndColorCube : MonoBehaviour
// {
//     public float moveDistance = 2f; // المسافة التي سيتحركها المكعب
//     public float scaleFactor = 1.2f; // عامل التكبير للحجم
//     private Vector3 originalPosition; // حفظ الموضع الأصلي للمكعب
//     private Vector3 originalScale; // حفظ الحجم الأصلي للمكعب
//     private Color originalColor; // حفظ اللون الأصلي للمكعب

//     void Start()
//     {
//         originalPosition = transform.position;
//         originalScale = transform.localScale;
//         originalColor = GetComponent<Renderer>().material.color;
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             if (transform.position.x == originalPosition.x)
//             {
//                 // تحريك المكعب لليمين وتكبيره وتغيير لونه
//                 transform.position += new Vector3(moveDistance, 0, 0);
//                 transform.localScale *= scaleFactor;
//                 GetComponent<Renderer>().material.color = Color.grey;
//             }
//             else
//             {
//                 // إعادة المكعب إلى حالته الأصلية
//                 transform.position = originalPosition;
//                 transform.localScale = originalScale;
//                 GetComponent<Renderer>().material.color = originalColor;
//             }
//         }
//     }
// }
