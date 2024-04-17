using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoR.Employees;

namespace CoR
{
    internal class Department : IOrderApprover
    {
        public required string Name { get; set; }
        public List<Employee> Employees { get; } = [];   
        public decimal OrderApprovalLimit => decimal.MaxValue;
        public void RequestOrderApproval(Order order)
        {
            Employees.Select(employee => employee.Level == 1).ToList().ForEach(employee =>
            {
                employee.RequestOrderApproval(order);
            });

            //foreach (Employee employee in Employees)
            //{
            //    employee.RequestOrderApproval(order);
            //}
        }
    }
}
