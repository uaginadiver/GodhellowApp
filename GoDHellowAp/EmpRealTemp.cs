using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDHellowAp
{
    class EmpRealTemp
    {
       
         static public Employees createEmployer()
        {
           
           Employees Emp = new Employees();

            Console.WriteLine("Введите сначала имя а потом фамилию без пезды");
            Emp.name = Console.ReadLine();
            Console.WriteLine("Настало время ввести фамилию");
            Emp.lastname = Console.ReadLine();
           
           
            return Emp;
        }
       
        

    }
}
