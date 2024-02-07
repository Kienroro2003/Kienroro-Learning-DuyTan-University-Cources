using System;
using System.Collections.Generic;

namespace Practie
{
    public class Contract
    {
        private Dictionary<string, ContractHiring> inventory = new Dictionary<string, ContractHiring>();

        public Contract()
        {
            while (true)
            {
                Console.WriteLine("1. Save a new Contract");
                Console.WriteLine("2. Find a Contract");
                Console.WriteLine("3. Remove a Contract");
                Console.WriteLine("4. Exit");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                    {
                        save();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter id contract: ");
                        string idContract = Console.ReadLine();
                        find(idContract);
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Enter id contract: ");
                        string idContract = Console.ReadLine();
                        remove(idContract);
                        break;
                    }
                    case 4:
                    {
                        return;
                    }
                }
            }
        }

        public void mainMenu()
        {
            
        }

        public void save()
        {
            Console.WriteLine("Enter id contract: ");
            string idContract = Console.ReadLine();
            ContractHiring newContractHiring = new ContractHiring();
            newContractHiring.inputContractHiring();
            inventory.Add(idContract, newContractHiring);
        }

        public void find(string idContract)
        {
            if (!inventory.ContainsKey(idContract))
            {
                Console.WriteLine("Not found");
                return;
            }
            inventory[idContract].display();
        }

        public void remove(string idContract)
        {
            if (!inventory.ContainsKey(idContract))
            {
                Console.WriteLine("Not found");
                return;
            }

            inventory.Remove(idContract);
            Console.WriteLine("Removed successfully!!");
        }
    }
}