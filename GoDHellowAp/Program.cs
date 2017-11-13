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
        static void Main(string[] args)

        {
            Employees Cmrd = EmpRealTemp.createEmployer();
            ArrayList Cw = new ArrayList();
            ArrayList Dz = new ArrayList();

            Cw.Add(Cmrd);
            Cw.Add(Cmrd);
            Cw.Add(Cmrd);

            foreach (Employees  o in Cw)
            { Console.WriteLine(Cmrd.name + " " + Cmrd.lastname); }
            Console.ReadLine();

          
        }


       
        }

            
            
        }
    

