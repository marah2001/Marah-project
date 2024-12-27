using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
 public class CustomObjectTest : MonoBehaviour
    {
        void Start()
        {
            CustomObject myObject = new CustomObject(1, "Example");
            Debug.Log(myObject);
        }
    }

    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static string RepeatString(this string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
    }}