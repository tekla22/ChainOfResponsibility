using CoR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.Employees
{
    internal class RegionDirector : Employee
    {
        public override decimal OrderApprovalLimit => 100000;
        public override int Level => 3;
        public override void RequestOrderApproval(Order order)
        {
            try
            {
                if (order == null) return;

                var mailServices = new Services.MailServices();

                if (order.Value <= OrderApprovalLimit)
                {
                    new Services.MailServices().SendEmail(string.Format("{0}.{1}@uni.lodz.pl", this.FirstName, this.LastName), "Order aproval request was sent");
                }
                else
                {
                    mailServices.SendEmail("board.members@uni.lodz.pl", " Board meeting requested for order approval");
                }
            }
            catch (Exception ex) { Console.Error.WriteLine(ex.ToString()); }

        }
    }
}
