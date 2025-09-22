using System;
using System.Collections.Generic;
using System.Text;

namespace DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS
{
    public class DiskTowerDto
    {
        public List<DiskDto> disks { get; set; }

        public int numberOfDisks { get; set; }
    }
}
