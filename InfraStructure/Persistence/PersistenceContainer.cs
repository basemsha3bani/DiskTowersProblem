using DiskTower.Application.Contracts;
using InfraStructure.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace InfraStructure.Persistence
{
    

        public static class ServiceCollectionExtension
        {
            public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
            {

                services.AddScoped(typeof( IRepository<>),typeof( GenericRepository<>));
                

                return services;
            }

        }
    }

    



