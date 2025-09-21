using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DiskTower.Application.Features.TestTower.Commands.CreateDisk.Validation
{
    internal abstract class  AbstractDiskTowerValidator

    {
       
        public abstract bool validate(DiskTowerDto disk);

        protected AbstractDiskTowerValidator nextValidator;


        
        

        protected bool PerformSubValidation(DiskTowerDto disk)
        {
            if(nextValidator==null)
            {
                return true;

            }
            return nextValidator.validate(disk);
        }
    }
    internal class disktoweNumberOfDisksValidator : AbstractDiskTowerValidator
    {
        public disktoweNumberOfDisksValidator(disktoweDisksSizeValidator disksSizeValidator)
        {
            this.nextValidator = disksSizeValidator;
        }

        public override bool validate(DiskTowerDto disk)
        {
           if(disk.numberOfDisks!=disk.disks.Count)
            {
                return false;
            }
            return base.PerformSubValidation(disk);
        }
    }
    internal class disktoweDisksSizeValidator : AbstractDiskTowerValidator
    {
        public override bool validate(DiskTowerDto disk)
        {
            if (disk.disks.Any(a=>a.size<=0))
            {
                return false;
            }
            return true;
        }
    }
}
