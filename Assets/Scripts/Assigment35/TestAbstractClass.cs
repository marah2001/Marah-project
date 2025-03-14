using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample derived = new DerivedClassExample();
            derived.PerformAction();
            derived.PrintInfo();
        }
    }
}
