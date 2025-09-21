using DiskTower.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InfraStructure.Persistence.Repository
{
    internal class GenericRepository<T> : IRepository<T> where T : class
    {
        public async Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }

   

}
