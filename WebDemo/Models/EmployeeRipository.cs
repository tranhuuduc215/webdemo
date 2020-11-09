using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class EmployeeRipository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRipository()
        {
            employees = new List<Employee>
            {
                new Employee(){Id = 1, Fullname = "Trung Quốc", Department = "IT", Email="trungquoc@gmail.com", AvatarPath="~/images/xuongrong1.jpg"},
                new Employee(){Id = 2, Fullname = "Trung Cộng", Department = "HR", Email="trungcong@gmail.com", AvatarPath="~/images/xuongrong1.jpg"},
                new Employee(){Id = 3, Fullname = "Ái Quốc", Department = "Sale", Email="aiquoc@gmail.com", AvatarPath="~/images/xuongrong1.jpg"},
                new Employee(){Id = 4, Fullname = "Tổ Quốc", Department = "GV", Email="toquoc@gmail.com", AvatarPath="~/images/xuongrong1.jpg"},
                new Employee(){Id = 5, Fullname = "Quốc Tế", Department = "Dep", Email="quocte@gmail.com", AvatarPath="~/images/xuongrong1.jpg"}

            };
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
