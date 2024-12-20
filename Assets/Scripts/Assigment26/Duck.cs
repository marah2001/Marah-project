using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
  public class Duck : Creature, IRunnable, ISwimmable
    {
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
    }
}