using AutoMapper;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiskTower.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<DiskDto, Disk>().ReverseMap();
            CreateMap<DiskTowerDto, Domain.DiskTower>().ReverseMap();
        }
    }
}
