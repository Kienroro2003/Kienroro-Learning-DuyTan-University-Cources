using System;

namespace Practie
{
    public class Employee: Person
    {
        private string idCustomer;
        private DateTime inspectionDate;
        
        public Employee()
        {
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Enter id customer: ");
            this.idCustomer = Console.ReadLine();
            Console.WriteLine("Enter inspection date: ");
            this.inspectionDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Id Customer: {this.idCustomer}\nInspection date: {this.inspectionDate}");
        }
    }
}