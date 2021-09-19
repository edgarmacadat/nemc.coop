using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NEMC.BL;
using NEMC.Common.Dto;
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
        private readonly IMapper _mapper;

        public MembershipController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<MembershipDTO> Get() {
            var allMembers = new UnitOfWork().MembershipBusinessLogic.GetAllMemberships();
            return _mapper.Map<List<MembershipDTO>>(allMembers);
        }
    }
}
