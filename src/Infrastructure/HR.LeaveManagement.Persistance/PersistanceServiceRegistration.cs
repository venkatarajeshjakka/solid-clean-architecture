﻿using System;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Persistance.DatabaseContext;
using HR.LeaveManagement.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Persistance;

public static class PersistanceServiceRegistration
{
    public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HrDatabaseContext>(
            options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HrDatabaseConnectionString"));
            });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
        services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
        services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

        return services;
    }
}

