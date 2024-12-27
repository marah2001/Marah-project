using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{

    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            // Upcasting
            Cat myCat = new Cat();
            Animal myAnimal = myCat; // Upcasting

            myAnimal.MakeSound();
            myAnimal.Move();

            // Downcasting
            Cat downcastedCat = myAnimal as Cat;
            if (downcastedCat != null)
            {
                downcastedCat.MakeSound();
                downcastedCat.Move();
            }

            // Type Checking
            List<ICanFight> fighters = new List<ICanFight>();

            fighters.Add(new Warrior());
            fighters.Add(new Warrior());

            foreach (ICanFight fighter in fighters)
            {
                fighter.Attack();

                if (fighter is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                else if (fighter is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }
            }
        }

    }
}