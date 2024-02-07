using System;

namespace Practie.exam
{
    public abstract class Employee
    {
        private string name;
        private string birthday;
        private bool gender;
        private string idPerson;
        private int id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public bool Gender
        {
            get => gender;
            set => gender = value;
        }

        public string IdPerson
        {
            get => idPerson;
            set => idPerson = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public Employee()
        {
        }

        public Employee(string name, string birthday, bool gender, string idPerson, int id)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.idPerson = idPerson;
            this.id = id;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter id: ");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id person: ");
            this.idPerson = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter birthday");
            this.birthday = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            this.gender = bool.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Id person: " + this.idPerson);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Birthday: " + this.birthday);
            Console.WriteLine("Gender: " + (this.gender ? "Male": "Female"));
        }

        public abstract double getActualSalary();
    }
}