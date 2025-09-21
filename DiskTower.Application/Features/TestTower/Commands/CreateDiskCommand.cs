using AutoMapper;
using DiskTower.Application.Contracts;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS
{
    internal class CreateDiskCommand
    {
        private IMapper _mapper;
        private IDiskTowerRepository _diskTowerRepository;

        public CreateDiskCommand(IDiskTowerRepository diskTowerRepository,IMapper mapper)
        {
            _mapper = mapper;
            _diskTowerRepository = diskTowerRepository;
        }

        public async Task<Domain.DiskTower> CreateDisk(DiskTowerDto towerDto)
        {
            Domain.DiskTower tower = _mapper.Map < Domain.DiskTower>(towerDto);
            return await _diskTowerRepository.CreateAsync(tower);


        }
    }
}
