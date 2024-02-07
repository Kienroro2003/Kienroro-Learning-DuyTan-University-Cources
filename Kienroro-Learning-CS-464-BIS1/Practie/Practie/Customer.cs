using System;

namespace Practie
{
    public class Customer: Person
    {
        private string id;
        private DateTime licenseDate;
        
        public override void input()
        {
            base.input();
            Console.WriteLine("Enter id: ");
            this.id = Console.ReadLine();
            Console.WriteLine("Enter license date: ");
            this.licenseDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Id Customer: {this.id}\nInspection date: {this.licenseDate}");
        }
    }
}