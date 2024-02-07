using System;

namespace Practie.exam
{
    public class ContractEmployee : Employee, IBenefit
    {
        private double contractSalary;

        public double ContractSalary
        {
            get => contractSalary;
            set => contractSalary = value;
        }

        public ContractEmployee()
        {
        }

        public ContractEmployee(double contractSalary)
        {
            this.contractSalary = contractSalary;
        }

        public ContractEmployee(string name, string birthday, bool gender, string idPerson, int id, double contractSalary) : base(name, birthday, gender, idPerson, id)
        {
            this.contractSalary = contractSalary;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter contract salary: ");
            this.contractSalary = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Contract salary: " + this.contractSalary);
            Console.WriteLine("Actual salary: " + this.getActualSalary());
        }

        public override double getActualSalary()
        {
            return this.contractSalary + this.getBenefit();
        }

        public double getBenefit()
        {
            return this.contractSalary / 10D;
        }
    }
}