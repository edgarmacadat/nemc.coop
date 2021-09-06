using NEMC.DataAccess;
using NEMC.DataAccess.Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using NEMC.BL.Interface;

namespace NEMC.BL
{
    public class MembershipBusinessLogic : IMembershipBusinessLogic
    {
        private ApplicationDbContext applicationDbContext;
        public MembershipBusinessLogic(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public IEnumerable<Membership> GetAllMemberships() {
            return applicationDbContext.Memberships.ToList();
        }
    }
}
