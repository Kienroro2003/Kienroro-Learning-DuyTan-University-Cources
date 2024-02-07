using System;

namespace Practie
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent");
        }

        public virtual void display()
        {
            Console.WriteLine("Parent class");
        }
    }
}