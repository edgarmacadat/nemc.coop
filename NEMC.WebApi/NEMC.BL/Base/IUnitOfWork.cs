using NEMC.BL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.BL
{
    public interface IUnitOfWork
    {
        IMembershipBusinessLogic MembershipBusinessLogic { get; }
    }
}
