using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public virtual void Move()
        {
            Debug.Log("Animal moves.");
        }
    }}
