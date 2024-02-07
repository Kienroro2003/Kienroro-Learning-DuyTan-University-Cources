using System;
using System.Collections.Generic;
using System.Linq;

namespace Practie.exam
{
    public class InventoryEmployee
    {
        private Dictionary<int, Employee> inventory;

        public InventoryEmployee()
        {
            this.inventory = new Dictionary<int, Employee>();
        }

        public void Input()
        {
            Employee employee;
            Console.WriteLine("1. Government Employee");
            Console.WriteLine("2. Contract Employee");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                {
                    employee = new GovernmentEmployee();
                    employee.Input();
                    inventory.Add(employee.Id, employee);
                    break;
                }
                case 2:
                {
                    employee = new ContractEmployee();
                    employee.Input();
                    inventory.Add(employee.Id, employee);
                    break;
                }
            }
        }

        public void Display()
        {
            foreach (KeyValuePair<int,Employee> employee in inventory)
            {
                employee.Value.Display();
            }
        }

        public double totalSalaryAllEmployee()
        {
            double res = 0;
            foreach (KeyValuePair<int,Employee> employee in inventory)
            {
                res += employee.Value.getActualSalary();
            }

            return res;
        }

        public void find()
        {
            Console.WriteLine("Enter id: ");
            int id = int.Parse(Console.ReadLine());
            if (!inventory.ContainsKey(id))
            {
                Console.WriteLine("Not found");
                return;
            }
            inventory[id].Display();
        }

        public void remove()
        {
            Console.WriteLine("Enter id: ");
            int id = int.Parse(Console.ReadLine());
            if (!inventory.ContainsKey(id))
            {
                Console.WriteLine("Not found");
                return;
            }

            inventory.Remove(id);
            Console.WriteLine("Removed successfully");
        }

        public void menu()
        {
            while (true)
            {
                Console.WriteLine("1. Input");
                Console.WriteLine("2. Display all");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Remove");
                Console.WriteLine("5. Exit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                    {
                        Input();
                        break;
                    }
                    case 2:
                    {
                        Display();
                        break;
                    }
                    case 3:
                    {
                        find();
                        break;
                    }
                    case 4:
                    {
                        remove();
                        break;
                    }
                    case 5:
                    {
                        return;
                    }
                }
            }
        }
    }
}