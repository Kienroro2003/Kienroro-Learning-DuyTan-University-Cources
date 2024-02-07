using System;

namespace Practie
{
    public class Travel : Vehicle
    {
        private int seat;

        public Travel()
        {
        }

        public Travel(string plateNumber, string name, int weight, DateTime inspectionDate, int seat) : base(plateNumber, name, weight, inspectionDate)
        {
            this.seat = seat;
        }

        public int Seat
        {
            get => seat;
            set => seat = value;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Enter seat: ");
            this.seat = int.Parse(Console.ReadLine());
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Seat: {0}", this.seat);
        }
    }
}