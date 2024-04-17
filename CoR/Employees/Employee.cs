using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.Employees
{
    internal abstract class Employee : IOrderApprover
    {
        public abstract int Level { get; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        public required string Position { get; set; }
        public Employee? Supervisor { get; set; }
        public abstract decimal OrderApprovalLimit { get; }
        public abstract void RequestOrderApproval(Order order);
    }
}
