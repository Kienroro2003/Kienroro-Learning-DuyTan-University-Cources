using System;

namespace Practie
{
    public class Vehicle
    {
        private string plateNumber;
        private string name;
        private int weight;
        private DateTime inspectionDate;
        public static int count = 0;

        public Vehicle()
        {
        }

        public Vehicle(string plateNumber, string name, int weight, DateTime inspectionDate)
        {
            this.plateNumber = plateNumber;
            this.name = name;
            this.weight = weight;
            this.inspectionDate = inspectionDate;
        }

        public string PlateNumber
        {
            get => plateNumber;
            set => plateNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public DateTime InspectionDate
        {
            get => inspectionDate;
            set => inspectionDate = value;
        }

        public static int Count
        {
            get => count;
            set => count = value;
        }


        public virtual void input()
        {
            Console.WriteLine("Enter plate of number: ");
            this.plateNumber = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter weight: ");
            this.weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inspection date: ");
            this.inspectionDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        public virtual void display()
        {
            Console.WriteLine($"Name: {this.name}\nPlate Number: {this.plateNumber}\nWeight: {this.weight}\nInspection Date: {this.inspectionDate}");
        }
    }
}