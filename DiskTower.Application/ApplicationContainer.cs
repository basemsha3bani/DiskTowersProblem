using AutoMapper;
using DiskTower.Application.Contracts;
using DiskTower.Application.Features.TestTower.Commands;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.Validation;
using DiskTower.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DiskTower.Application
{
    

public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Fix: Use the correct overload of AddAutoMapper that accepts assembly types
            services.AddAutoMapper(cfg => cfg.AddProfile<MapperProfile>());
            services.AddValidation();
            services.AddScoped(typeof(CreateDiskCommand));

            return services;
        }
        private static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services.AddScoped(typeof(AbstractDiskTowerValidator),typeof(disktoweNumberOfDisksValidator));
            services.AddScoped(typeof(AbstractDiskTowerValidator), typeof(disktoweDisksSizeValidator));
            return services;
        }
       
    }
    }

    



