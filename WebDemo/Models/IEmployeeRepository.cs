using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();

    }
}
