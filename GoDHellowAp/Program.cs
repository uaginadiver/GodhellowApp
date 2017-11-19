using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GoDHellowAp
{
    class Program
    {
        private static string LIST_OF_COMMAND = "1.Добавить работника\n" +
            "2.Посмотреть работников\n" + "3.Список комманд\n"+"4.сколько работников\n"+"5.Выход";

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй друг! Вбыери коммандо:");
            Console.WriteLine(LIST_OF_COMMAND);
            List<Employees> employeesList = new List<Employees>();
            int cmnd;
            bool isAlive = true;

            while (isAlive)
            {
                Console.WriteLine("Введите команду");
                cmnd = int.Parse(Console.ReadLine());
                switch (cmnd)
                {
                    case 1:
                        Employees employeer = EmpRealTemp.createEmployer();
                        employeesList.Add(employeer);
                        break;
                    case 2:
                        foreach (Employees e in employeesList)
                        { Console.WriteLine(e.name + " " + e.lastname); }
                        break;
                    case 3:
                        Console.WriteLine(LIST_OF_COMMAND);
                        break;

                    case 4:
                        Console.WriteLine("количество работников"+employeesList.Count);
                        break;
                    case 5:
                        isAlive = false;
                        break;
                         
                    default:
                        Console.WriteLine("vvedy normalno");
                        break;
                }

            }
        }
    }
}

















