using CoR;
using CoR.Employees;

namespace CoR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new RegionDirector
            {
                FirstName = "Jan",
                LastName = "Nowak",
                Poistion = "It Manager"
            };

            var manager = new CountryManager
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Poistion = "Tech Leader",
                Supervisor = director
            };

            var expert = new LowLevelEmployee
            {
                FirstName = "Krzysztof",
                LastName = "Kowalczyk",
                Poistion = "Junior Developer",
                Supervisor = manager
            };

            var department = new Department { Name = "IT Department" };

            department.Employees.Add(expert);
            department.Employees.Add(manager);
            department.Employees.Add(director);

            department.RequestOrderApproval(new Order
            {
                ID = "O/1/2024",
                Count = 1,
                Price = 100
            });

            department.RequestOrderApproval(new Order
            {
                ID = "O/1/2024",
                Count = 144,
                Price = 100
            });

            department.RequestOrderApproval(new Order
            {
                ID = "O/1/2024",
                Count = 331,
                Price = 10220
            });
        }
    }
}