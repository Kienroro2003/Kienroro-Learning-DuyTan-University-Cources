using System;
using System.Collections.Generic;
using System.Linq;

namespace Practie
{
    public class Exam
    {
        private const int REPEAT_N_TIMES = 10;
        private const char CHAR_FOR_REPEAT = '=';

        private static void label(string text)
        {
            Console.WriteLine($"{new String(CHAR_FOR_REPEAT, REPEAT_N_TIMES)} {text} {new String(CHAR_FOR_REPEAT, REPEAT_N_TIMES)}");
        }

        public static void Bai1()
        {
            label("Begin Bai1");
            Console.WriteLine("Enter index: ");
            int index = inputNumber();
            Console.WriteLine("Fibo at index {0} is {1}", index, fiboAtIndex(index));
            Console.WriteLine("Enter n: ");
            int n = inputNumber();
            Console.WriteLine("Total fibo with {0} elements is {1}", n, fiboTotal(n));
            label("End Bai1");
            
        }

        private static int fiboAtIndex(int n)
        {
            if (n == 0 || n == 1) return n;
            return fiboAtIndex(n - 1) + fiboAtIndex(n - 2);
        }


        private static int fiboTotal(int n)
        {
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += fiboAtIndex(i);
            }

            return total;
        }

        public static void Bai2()
        {
            label("Begin Bai2");
            Console.WriteLine("Enter month: ");
            int month = inputNumber();
            calculateDayInMonth(month);
            label("End Bai2");
        }

        private static void calculateDayInMonth(int month)
        {
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                {
                    days = 31;

                    break;
                }
                case 4:
                case 6:
                case 9:
                case 11:
                {
                    days = 30;
                    Console.WriteLine($"Month {month} has 30 days");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter year: ");
                    int year = inputNumber();
                    if (year % 100 != 0 && year % 4 == 0) days = 29;
                    else days = 28;
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid format");
                    return;
                }
            }

            Console.WriteLine($"Month {month} has {days} days");
        }

        private static int inputNumber()
        {
            bool loop = true;
            int n = 0;
            while (loop)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n >= 0)
                {
                    loop = false;
                }
                else Console.WriteLine("Invalid!!! Enter a positive integer: ");
            }

            return n;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int) Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void Bai3()
        {
            label("Begin Bai3");
            Console.WriteLine("Enter n: ");
            int n = inputNumber();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter array[{0}]: ", i);
                array[i] = inputNumber();
            }

            Console.WriteLine("Max: {0}", array.Max());
            Console.WriteLine("Min: {0}", array.Min());
            Console.Write("Prime: ");
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(array[i]))
                {
                    Console.Write("{0}\t", array[i]);
                }
            }
            Console.WriteLine();
            label("End Bai3");
        }
        

        public static void Bai4()
        {
            label("Begin Bai4");
            int[,] array2D = inputArray2D();
            displayArray2D(array2D);
            Console.WriteLine("Enter row to remove: ");
            int index = inputNumber();
            int[,] array2DAfterRemove = deleteRowAtIndex(array2D, index);
            displayArray2D(array2DAfterRemove);
            label("End Bai1");

        }

        private static void displayArray2D(int[,] array2D)
        {
            int rows = array2D.GetLength(0);
            int cols = array2D.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0}\t", array2D[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int[,] inputArray2D()
        {
            Console.WriteLine("Enter rows: ");
            int rows = inputNumber();
            Console.WriteLine("Enter cols: ");
            int cols = inputNumber();
            int[,] array2D = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int max = int.MinValue;
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine("Enter array[{0}, {1}]: ", row, col);
                    array2D[row, col] = inputNumber();
                    if (array2D[row, col] > max) max = array2D[row, col];
                }

                Console.WriteLine("Max in the row {0} is {1}", row, max);
            }

            return array2D;
        }

        private static int[,] deleteRowAtIndex(int[,] array2D, int index)
        {
            int[,] res = new int[array2D.GetLength(0)-1, array2D.GetLength(1)];
            int currentRow = 0;
            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                if(row == index)continue;
                for (int col = 0; col < array2D.GetLength(1); col++)
                {
                    res[currentRow, col] = array2D[row, col];
                }

                currentRow++;
            }

            return res;
        }

        public static void Bai5()
        {
            label("Begin Bai5");
            mainMenu();
            label("End Bai5");
        }

        private static void mainMenu()
        {
            Dictionary<string, string> vehicles = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add new Vehicle");
                Console.WriteLine("2. Remove a Vehicle");
                Console.WriteLine("3. Find a Vehicle");
                int choose = inputNumber();
                switch (choose)
                {
                    case 1:
                    {
                        addVehicle(vehicles);
                        break;
                    }
                    case 2:
                    {
                        removeVehicle(vehicles);
                        break;
                    }
                    case 3:
                    {
                        findVehicle(vehicles);
                        break;
                    }
                    case 0:
                    {
                        return;
                    }
                }
            }
        }

        private static void addVehicle(Dictionary<string, string> inventory)
        {
            Console.WriteLine("Enter id vehicle: ");
            string idVehicle = Console.ReadLine();
            if (inventory.ContainsKey(idVehicle))
            {
                Console.WriteLine("The vehicle exists");
                return;
            }

            Console.WriteLine("Enter information vehicle: ");
            string infoVehicle = Console.ReadLine();
            inventory.Add(idVehicle, infoVehicle);
            Console.WriteLine("Added a Vehicle");

        }

        private static void removeVehicle(Dictionary<string, string> inventory)
        {
            Console.WriteLine("Enter id vehicle: ");
            string idVehicle = Console.ReadLine();
            if (!inventory.ContainsKey(idVehicle))
            {
                Console.WriteLine("The vehicle does not exist");
                return;
            }

            inventory.Remove(idVehicle);
            Console.WriteLine("Removed successfully");
        }

        private static void findVehicle(Dictionary<string, string> inventory)
        {
            Console.WriteLine("Enter id vehicle: ");
            string idVehicle = Console.ReadLine();
            if (!inventory.ContainsKey(idVehicle))
            {
                Console.WriteLine("The vehicle does not exist");
                return;
            }

            Console.WriteLine($"Id: {idVehicle}, info: {inventory[idVehicle]}");
        }
        
        
    }
}