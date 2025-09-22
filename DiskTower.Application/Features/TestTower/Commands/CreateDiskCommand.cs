using AutoMapper;
using DiskTower.Application.Contracts;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.Validation;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiskTower.Application.Features.TestTower.Commands
{
    public class CreateDiskCommand
    {
        private IMapper _mapper;
        private IRepository<DiskTower.Domain.DiskTower> _diskTowerRepository;
        private AbstractDiskTowerValidator _towerValidator;

        public CreateDiskCommand(IRepository<DiskTower.Domain.DiskTower> diskTowerRepository,IMapper mapper, AbstractDiskTowerValidator towerValidator)
        {
            _mapper = mapper;
            _diskTowerRepository = diskTowerRepository;
            _towerValidator = towerValidator;
        }

        public async Task<string> CreateDisk(DiskTowerDto towerDto)
        {
            if (!_towerValidator.validate(towerDto))
            {
                await Task.Delay(100);
                return _towerValidator.validationMessage;
            }
            Domain.DiskTower tower = _mapper.Map < Domain.DiskTower>(towerDto);
            
            return await _diskTowerRepository.CreateAsync(tower);


        }
    }
}
