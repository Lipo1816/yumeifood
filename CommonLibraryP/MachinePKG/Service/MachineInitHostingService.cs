﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CommonLibraryP.LogPKG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryP.MachinePKG
{
    public class MachineInitHostingService : BackgroundService
    {
        private readonly IServiceScopeFactory scopeFactory;
        public MachineInitHostingService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var machineService = scope.ServiceProvider.GetRequiredService<MachineService>();
                await machineService.InitAllModbusSlaves();
                //SerilogByNamespaceRollbyday.Information("InitAllModbusSlaves");
                await machineService.InitAllMachinesFromDB();
            }
        }
    }
}
