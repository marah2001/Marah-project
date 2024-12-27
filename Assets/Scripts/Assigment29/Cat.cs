using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
 public class Cat : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public override void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
    }
}