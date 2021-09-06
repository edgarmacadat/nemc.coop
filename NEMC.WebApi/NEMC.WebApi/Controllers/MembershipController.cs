using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NEMC.BL;
using NEMC.DataAccess;
using NEMC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEMC.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembershipController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        //public MembershipController(UnitOfWork unitOfWork) {
        //    _unitOfWork = unitOfWork;
        //}

        public MembershipController()
        {
            //_unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Membership> Get() {
            var testResult = new UnitOfWork().MembershipBusinessLogic.GetAllMemberships();
            return testResult;
        }
    }
}
