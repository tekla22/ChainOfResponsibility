﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    internal class IOrderApprover
    {
        decimal OrderApprovalLimit { get; }
        void RequestOrderApproval(Order order);
    }
}
