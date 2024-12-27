using System.Collections;
using System.Collections.Generic;
// Part 1: BasicsScript
using UnityEngine;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            // Declare three variables using var
            var myInt = 10;

            // Use ternary operator
            string message = myInt % 2 == 0 ? $"{myInt} is even." : $"{myInt} is odd.";
            Debug.Log(message);

            // Log current date and time
            Debug.Log($"Current Date: {System.DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {System.DateTime.Now.ToShortTimeString()}");
            Debug.Log($"Current Day: {System.DateTime.Now.DayOfWeek}");
        }
    }}