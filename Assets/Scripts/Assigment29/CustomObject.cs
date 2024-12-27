using System.Collections;
using System.Collections.Generic;

namespace Assignment29
{
 public class CustomObject
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        // [Optional] - Commented out as per instructions
        // public override bool Equals(object obj)
        // {
        //     if (obj == null || GetType() != obj.GetType())
        //     {
        //         return false;
        //     }

        //     CustomObject other = (CustomObject)obj;
        //     return ID == other.ID && Name == other.Name;
        // }

        // [Optional] - Commented out as per instructions
        // public static bool operator ==(CustomObject a, CustomObject b)
        // {
        //     if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
        //     {
        //         return true;
        //     }

        //     if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
        //     {
        //         return false;
        //     }

        //     return a.Equals(b);
        // }

        // [Optional] - Commented out as per instructions
        // public static bool operator !=(CustomObject a, CustomObject b)
        // {
        //     return !(a == b);
        // }
    }}