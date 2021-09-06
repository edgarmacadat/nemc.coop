using NEMC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.BL.Interface
{
    public interface IMembershipBusinessLogic
    {
        public IEnumerable<Membership> GetAllMemberships();
    }
}
