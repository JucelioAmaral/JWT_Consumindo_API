using AutoMapper;
using MonitoraEquipamentos.Application.Dto;
using MonitoraEquipamentos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.api.Helpers
{
    public class MonitoraEquipamentosProfile : Profile
    {
        public MonitoraEquipamentosProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Equipamento, EquipamentoDto>().ReverseMap();
        }
    }
}
