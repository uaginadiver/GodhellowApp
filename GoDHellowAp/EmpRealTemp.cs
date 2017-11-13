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
            Emp.name = Console.ReadLine();               
            Emp.lastname = Console.ReadLine();
           
           
            return Emp;
        }
       
        

    }
}
