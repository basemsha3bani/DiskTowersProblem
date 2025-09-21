using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiskTower.Application.Contracts
{
    public interface IRepository<T> where T : class

    {

        
        Task<T> CreateAsync(T entity);

       

        


    }
    
   
}
