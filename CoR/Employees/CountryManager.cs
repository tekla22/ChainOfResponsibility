using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.Employees
{
    internal class CountryManager : Employee
    {
        public override decimal OrderApprovalLimit => 10000;

        public override int Level => 2;

        public override void RequestOrderApproval(Order order)
        {
            try
            {
                if (order == null) return;

                if (order.Value <= OrderApprovalLimit)
                {
                    new Services.MailServices().SendEmail(string.Format("{0}.{1}@uni.lodz.pl", this.FirstName, this.LastName), "Order aproval request was sent");
                }
                else if (this.Supervisor != null) { this.Supervisor.RequestOrderApproval(order); }
                else { Console.WriteLine("Order can not be approved"); }
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.ToString()); }
        }
    }
}
