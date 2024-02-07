using System;
using System.Collections.Generic;
using System.Linq;
using Practie.exam;

namespace Practie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Student student = new Student();
            // student.play();
            InventoryEmployee inventory = new InventoryEmployee();
            inventory.menu();
        }

        public static void Buoi11()
        {
            Contract contract = new Contract();
            contract.mainMenu();
        }

        public static void Buoi10()
        {
            // Person employee = new Employee();
            // employee.input();
            // employee.display();
            ContractHiring hiring = new ContractHiring();
            hiring.inputContractHiring();
            hiring.display();
        }

        public static void Buoi9()
        {
            ManageVehicle manageVehicle = new ManageVehicle();
            manageVehicle.menu();
        }

        public static void Buoi8()
        {
            // Parent parent = new Parent();
            // parent.display();
            ManageVehicle manageVehicle = new ManageVehicle();
            manageVehicle.menu();
        }

        public static void Buoi7()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle vehicle2 = new Vehicle();
            Vehicle vehicle3 = new Vehicle();
            // vehicle.input();
            // vehicle.display();
            Console.WriteLine(Vehicle.count);
        }

        public static void Buoi6()
        {
            Exam.Bai1();
            Exam.Bai2();
            Exam.Bai3();
            Exam.Bai4();
            Exam.Bai5();
        }
        
        public static void Buoi5()
        {
            // Dictionary<string, string> subjectDictionary = new Dictionary<string, string>();
            // Console.WriteLine("Enter number of subject: ");
            // int num = int.Parse(Console.ReadLine());
            // for (int i = 0; i < num; i++)
            // {
            //     Console.WriteLine("Enter ID subject: ");
            //     string idSubject = Console.ReadLine();
            //     Console.WriteLine("Enter name of subject: ");
            //     string nameSubject = Console.ReadLine();
            //     if(subjectDictionary.ContainsKey(idSubject))continue;
            //     subjectDictionary.Add(idSubject, nameSubject);
            // }
            //
            // subjectDictionary.ToList().ForEach(pair => Console.WriteLine("{0}: {1}", pair.Key, pair.Value));
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            Console.WriteLine("Enter n students: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student newStudent = new Student();
                if (studentDictionary.ContainsKey(newStudent.Id))
                {
                    Console.WriteLine(newStudent);
                }
                else
                {
                    studentDictionary.Add(newStudent.Id, newStudent);
                }
                
            }
            studentDictionary.ToList().ForEach(pair => Console.WriteLine(pair.Value));
        }

        public static void Buoi4()
        {
            // Console.WriteLine("Nhập năm dương lịch: ");
            // int year = int.Parse(Console.ReadLine());
            // Console.WriteLine("{0} {1}", canArray(year), chiArray(year%12));
            int[] array = inputArray();
            int[,] matrix = new int[,] {{1, 2, 3, 4}, {1, 2, 3, 4}};
            displayArray(array);
            Console.WriteLine("Tong: {0}", sumArray(array));
            Console.WriteLine("So lon nhat: {0}", maxArray(array));
            Console.WriteLine("So luong cac so nguyen duong : {0}", sumPositiveArray(array));
            Console.WriteLine("So tong cac so nguyen duong : {0}", countPositiveArray(array));
        }

        public static void Buoi3()
        {
            Console.WriteLine(default(Boolean));
            int bai1, bai2, bai3, bai4 = 5, bai5;
            Console.WriteLine("Nhap so bai 1: ");
            bai1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua bai 1: {0}", Bai1(bai1));
            Console.WriteLine("Nhap so bai 2: ");
            bai2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua bai 2: {0}", Bai2(bai2));
            Console.WriteLine("Nhap so bai 3: ");
            bai3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua bai 3: {0}", Bai3(bai3));
            Console.WriteLine("Ket qua bai 4: ");
            Bai4And5(bai4, true);
            Bai4And5(bai4, false);
            Console.WriteLine("Nhap so bai 5: ");
            bai5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua bai 5: ");
            Bai4And5(bai5, false);
        }

        public static int[] inputArray()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        public static void displayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t\t", array[i]);
            }
            Console.WriteLine();
        }

        public static int sumArray(int[] array)
        {
            return array.Sum();
        }

        public static int maxArray(int[] array)
        {
            return array.Max();
        }

        public static int sumPositiveArray(int[] array)
        {
            return array.Where(num => num >= 0).Sum();
        }

        public static int countPositiveArray(int[] array)
        {
            return array.Count(num => num >= 0);
        }

        public static string canArray(int year)
        {
            string[] cans = {"Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ"};
            return cans[year % 10];
        }
        
        public static string chiArray(int year)
        {
            string[] chis = {"Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi"};
            return chis[year % 12];
        }

        public static string can(int num)
        {
            switch (num)
            {
                case 0:
                {
                    return "Canh";
                }
                case 1:
                {
                    return "Tân";
                }
                case 2:
                {
                    return "Nhâm";
                }
                case 3:
                {
                    return "Quý";
                }
                case 4:
                {
                    return "Giáp";
                }
                case 5:
                {
                    return "Ất";
                }
                case 6:
                {
                    return "Bính";
                }
                case 7:
                {
                    return "Đinh";
                }
                case 8:
                {
                    return "Mậu";
                }
                case 9:
                {
                    return "Kỷ";
                }
                default: return "";
            }
            
        }
        
        public static string chi(int num)
        {
            switch (num)
            {
                case 0:
                {
                    return "Thân";
                }
                case 1:
                {
                    return "Dậu";
                }
                case 2:
                {
                    return "Tuất";
                }
                case 3:
                {
                    return "Hợi";
                }
                case 4:
                {
                    return "Tý";
                }
                case 5:
                {
                    return "Sửu";
                }
                case 6:
                {
                    return "Dần";
                }
                case 7:
                {
                    return "Mẹo";
                }
                case 8:
                {
                    return "Thìn";
                }
                case 9:
                {
                    return "Tỵ";
                }
                case 10:
                {
                    return "Ngọ";
                }
                case 11:
                {
                    return "Mùi";
                }
                default: return "";
            }
        }

        public static int Bai1(int n)
        {
            if (n == 1) return 1;
            return n + Bai1(n - 1);
        }

        public static int Bai2(int n)
        {
            if (n == 1) return 1;
            return (int)Math.Pow(n, 2) + Bai2(n - 1);
        }

        public static int Bai3(int n)
        {
            if (n == 1) return 1;
            return n * Bai3(n - 1);
        }

        public static void Bai4And5(int n, bool isFill)
        {
            
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n-i-1; j++)
                    {
                        Console.Write(' ');
                    }

                    for (int j = 0; j < i*2+1; j++)
                    {
                        if (isFill)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if (j == 0 || j == i * 2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                if(i == n-1) Console.Write("*");
                                else Console.Write(" ");
                            }
                        }
                    }

                    Console.WriteLine();
                }
        }
    }
}