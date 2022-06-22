using AutoMapper;
using SelfHostedServer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedServer.ModelsDTO.ModelsDto.AutoMapperProfiles
{
    public class RefundDtoProfile : Profile
    {
        public RefundDtoProfile()
        {
            CreateMap<Refund, RefundDto>().ReverseMap();
        }
    }
}
