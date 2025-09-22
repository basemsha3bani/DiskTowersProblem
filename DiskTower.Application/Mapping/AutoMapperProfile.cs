using AutoMapper;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiskTower.Application.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<DiskDto, Disk>().ReverseMap();
            CreateMap<DiskTowerDto, Domain.DiskTower>().ReverseMap();
        }
    }
}
