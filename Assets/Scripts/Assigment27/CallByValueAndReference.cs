using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;

            CallByValue(a); 
            Debug.Log("بعد الاستدعاء بالقيمة: a = " + a); 

            CallByReference(ref b);
            Debug.Log("بعد الاستدعاء بالمرجع: b = " + b); 

            int c; 
            CallByOut(out c);
            Debug.Log("بعد CallByOut: c = " + c); 
        }

        void CallByValue(int x)
        {
            x += 10; 
            Debug.Log("داخل CallByValue: x = " + x); 
        }

        void CallByReference(ref int x)
        {
            x += 10; 
            Debug.Log("داخل CallByReference: x = " + x); 
        }

        void CallByOut(out int x)
        {
            x = 20; 
            Debug.Log("داخل CallByOut: x = " + x); 
        }
    }
}
