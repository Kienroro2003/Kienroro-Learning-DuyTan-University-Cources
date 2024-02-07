using System;
using System.Collections.Generic;

namespace Practie
{
    public class ManageVehicle
    {
        private Dictionary<string, Vehicle> inventory = new Dictionary<string, Vehicle>();

        public void menu()
        {
            while (true)
            {
                Console.WriteLine("1. Enter");
                Console.WriteLine("2. Display all");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Remove");
                Console.WriteLine("5. Exit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                    {
                        input();
                        break;
                    }
                    case 2:
                    {
                        display();
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

        public void input()
        {
            Console.WriteLine("1. Travel Vehicle");
            Console.WriteLine("2. Truck Vehicle");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                {
                    Travel travel = new Travel();
                    travel.input();
                    inventory.Add(travel.PlateNumber, travel);
                    break;
                }
                case 2:
                {
                    Truck truck = new Truck();
                    truck.input();
                    inventory.Add(truck.PlateNumber, truck);
                    break;
                }
            }
        }

        public void display()
        {
            foreach (KeyValuePair<string,Vehicle> vehicle in inventory)
            {
                vehicle.Value.display();
            }
        }

        public void find()
        {
            Console.WriteLine("Enter plate of number: ");
            string plateNumber = Console.ReadLine();
            if (!inventory.ContainsKey(plateNumber))
            {
                Console.WriteLine("Not found");
                return;
            }
            inventory[plateNumber].display();
        }

        public Vehicle getVehicleByPlateNumber(string plateNumber)
        {
            return this.inventory[plateNumber];
        }

        public bool isExistVehicle(string plateNumber)
        {
            return inventory[plateNumber] != null;
        }

        public void remove()
        {
            Console.WriteLine("Enter plate of number: ");
            string plateNumber = Console.ReadLine();
            if (!inventory.ContainsKey(plateNumber))
            {
                Console.WriteLine("Not found");
                return;
            }

            inventory.Remove(plateNumber);
        }
    }
}