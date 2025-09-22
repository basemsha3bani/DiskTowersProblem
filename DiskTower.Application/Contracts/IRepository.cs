using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DiskTower.Application.Contracts
{
    public interface IRepository<T> where T : GnericEntity

    {

        
        Task<string> CreateAsync(T entity);

       

        


    }
    
   
}
