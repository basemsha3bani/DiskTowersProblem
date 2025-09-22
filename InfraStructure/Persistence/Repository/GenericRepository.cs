using DiskTower.Application.Contracts;
using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InfraStructure.Persistence.Repository
{
    internal class GenericRepository<T> : IRepository<T> where T : GnericEntity
    {
        public async Task<string> CreateAsync(T entity)
        {
            await Task.Delay(1000);
            entity.key = Guid.NewGuid();
            return entity.key.ToString();
        }
    }

   

}
