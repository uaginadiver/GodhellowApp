using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDHellowAp
{
    class EmpRealTemp
    {
        public Employees Emp = new Employees();
        public Employees createEmployer(string nm, string lstnm, DateTime dt1, DateTime dt2)
        {

            Emp.name = nm;
            Emp.lastname = lstnm;
            Emp.PrefermDate.Add(dt1);
            Emp.PrefermDate.Add(dt2);
            return Emp;
        }


    }
}
