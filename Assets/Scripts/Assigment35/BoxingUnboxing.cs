using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxedHealth = health; // Boxing
            int unboxedHealth = (int)boxedHealth; // Unboxing
            unboxedHealth += 50;

            Debug.Log($"Original health: {health}");
            Debug.Log($"Boxed health: {boxedHealth}");
            Debug.Log($"Unboxed and modified health: {unboxedHealth}");
        }
    }
}
