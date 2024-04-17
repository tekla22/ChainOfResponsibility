using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        protected Handler Succesor;

        public void SetSuccesor(Handler succesor)
        {
            this.Succesor = succesor;
        }

        public abstract void HandleRequest(Request request);
    }
}
