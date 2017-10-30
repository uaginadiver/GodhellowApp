using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDHellowAp
{
    class Employees
    {
        
       string Name;
        String Lastname;
        List<DateTime> prefermDate;
        public string name { set; get; }
        public string lastname { set; get; }
        public List<DateTime> PrefermDate { set; get; }

        public Employees print()
        {
            Console.WriteLine(name + lastname);
            return new Employees();
        }
    }
}

