using AutoMapper;
using NEMC.Common.Dto;
using NEMC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEMC.BL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Membership, MembershipDTO>();
            CreateMap<PersonalData, PersonalDataDTO>();
            CreateMap<Address, AddressDTO>();
        }
    }
}
