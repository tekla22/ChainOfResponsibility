using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    internal class Handler1 : Handler
    {
        public override void HandleRequest(Request request)
        {
            if(request.Value>0 && request.Value<=10)
            {
                Console.WriteLine($"{request.Name} handled request {request.Value}");
            }
            else if(Succesor!=null)
            {
                Succesor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Request not handled");
            }
        }
    }
}
