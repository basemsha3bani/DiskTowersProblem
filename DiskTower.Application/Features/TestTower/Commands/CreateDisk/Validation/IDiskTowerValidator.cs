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
    public abstract class  AbstractDiskTowerValidator

    {
       
        public abstract bool validate(DiskTowerDto disk);

        protected AbstractDiskTowerValidator nextValidator;
        public string validationMessage { get; set; }

        
        

        protected bool PerformSubValidation(DiskTowerDto disk)
        {
            if(nextValidator==null)
            {
                return true;

            }
            return nextValidator.validate(disk);
        }
    }
    public class disktoweNumberOfDisksValidator : AbstractDiskTowerValidator
    {
        public disktoweNumberOfDisksValidator(disktoweDisksSizeValidator disksSizeValidator)
        {
            this.nextValidator = disksSizeValidator;
        }

        public override bool validate(DiskTowerDto disk)
        {
           if(disk.numberOfDisks!=disk.disks.Count)
            {
                validationMessage= "Number of disks does not match the count of disks provided.";
                return false;
            }
           
            return base.PerformSubValidation(disk);
        }
    }
    public class disktoweDisksSizeValidator : AbstractDiskTowerValidator
    {
        public override bool validate(DiskTowerDto disk)
        {
            if (disk.disks.Any(a=>a.size<=0))
            {
                validationMessage = "There are invalid disk sizes";
                return false;
            }
            return true;
        }
    }
}
