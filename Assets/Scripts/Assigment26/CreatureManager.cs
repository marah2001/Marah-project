using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
 public class CreatureManager : MonoBehaviour
    {
        private List<Creature> creatures = new List<Creature>();
        private List<IRunnable> runners = new List<IRunnable>();
        private List<IJumpable> jumpers = new List<IJumpable>();
        private List<ISwimmable> swimmers = new List<ISwimmable>();

        void Start()
        {
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            creatures.Add(kangaroo);
            creatures.Add(duck);

            runners.Add(kangaroo);
            runners.Add(duck);
            jumpers.Add(kangaroo);
            swimmers.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runner in runners)
            {
                runner.Run();
            }

            foreach (IJumpable jumper in jumpers)
            {
                jumper.Jump();
            }

            foreach (ISwimmable swimmer in swimmers)
            {
                swimmer.Swim();
            }
        }
    }
}