using System;

namespace Practie.exam
{
    public class GovernmentEmployee : Employee, IBenefit
    {
        private double coeff;
        private double salary;

        public double Coeff
        {
            get => coeff;
            set => coeff = value;
        }

        public GovernmentEmployee()
        {
        }

        public GovernmentEmployee(string name, string birthday, bool gender, string idPerson, int id, double coeff) : base(name, birthday, gender, idPerson, id)
        {
            this.coeff = coeff;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter coeff: ");
            this.coeff = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary: ");
            this.salary = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Coeff: " + this.coeff);
            Console.WriteLine("Salary: " + this.salary);
            Console.WriteLine("Actual Salary: " + this.getActualSalary());
        }

        public override double getActualSalary()
        {
            return this.coeff * this.salary + this.getBenefit();
        }

        public double getBenefit()
        {
            return this.salary / 10D;
        }
    }
}