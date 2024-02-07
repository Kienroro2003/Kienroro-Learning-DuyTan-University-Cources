using System;

namespace Practie
{
    public class Student : IComparable<Student>, Gamer
    {
        public int CompareTo(Student other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(birthday, other.birthday, StringComparison.Ordinal);
        }

        protected string id;
        protected string name;
        protected string address;
        protected string birthday;

        public string Id => id;

        public string Name => name;

        public string Address => address;

        public string Birthday => birthday;

        // protected bool Equals(Student other)
        // {
        //     return id == other.id && name == other.name;
        // }
        //
        // public override bool Equals(object obj)
        // {
        //     if (ReferenceEquals(null, obj)) return false;
        //     if (ReferenceEquals(this, obj)) return true;
        //     if (obj.GetType() != this.GetType()) return false;
        //     return Equals((Student) obj);
        // }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((id != null ? id.GetHashCode() : 0) * 397) ^ (name != null ? name.GetHashCode() : 0);
            }
        }

        public Student()
        {
            Console.WriteLine("Enter id: ");
            this.id = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            this.address = Console.ReadLine();
            Console.WriteLine("Enter birthday");
            this.birthday = Console.ReadLine();
        }

        public override string ToString()
        {
            return
                $"Name: {this.name}{Environment.NewLine}Address: {this.address}{Environment.NewLine}Birthday: {this.birthday}";
        }

        public void play()
        {
            throw new NotImplementedException();
        }
    }
}