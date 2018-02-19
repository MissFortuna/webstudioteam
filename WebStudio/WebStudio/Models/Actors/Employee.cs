using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStudio.Classes
{
    interface Employee
    {
        int id { get; set; }
        string name { get; set; }
        string position { get; }
        int salary { get; set; }
    }
}
