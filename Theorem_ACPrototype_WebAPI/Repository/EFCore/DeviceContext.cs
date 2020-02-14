using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theorem_ACPrototype_WebAPI.Models;

namespace Theorem_ACPrototype_WebAPI.Repository.EFCore
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options)
            : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
    }
}
