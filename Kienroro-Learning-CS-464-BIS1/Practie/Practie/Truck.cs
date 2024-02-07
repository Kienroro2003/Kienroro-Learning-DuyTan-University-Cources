using System;

namespace Practie
{
    public class Truck : Vehicle
    {
        private double ton;
        public override void input()
        {
            base.input();
            Console.WriteLine("Enter ton: ");
            this.ton = double.Parse(Console.ReadLine());
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Ton: {0}", this.ton);
        }
    }
}