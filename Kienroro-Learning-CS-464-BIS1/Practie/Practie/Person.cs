using System;

namespace Practie
{
    public class Person
    {
        private long personId;
        private string name;
        private string address;
        private string phoneNumber;

        public long PersonId
        {
            get => personId;
            set => personId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public Person()
        {
        }

        public Person(long personId, string name, string address, string phoneNumber)
        {
            this.personId = personId;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public virtual void input()
        {
            Console.WriteLine("Enter person id: ");
            this.personId = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            this.address = Console.ReadLine();
            Console.WriteLine("Enter number of the phone: ");
            this.phoneNumber = Console.ReadLine();
        }

        public virtual void display()
        {
            Console.WriteLine($"Name: {this.name}\nAddress: {this.address}\nPhone number: {this.phoneNumber}");
        }
    }
}