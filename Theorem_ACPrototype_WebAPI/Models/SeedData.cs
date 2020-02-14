using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theorem_ACPrototype_WebAPI.Repository.EFCore;

namespace Theorem_ACPrototype_WebAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeviceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeviceContext>>()))
            {
                // Look for any movies.
                if (context.Devices.Any())
                {
                    return;   // DB has been seeded
                }

                context.Devices.AddRange(
                    new Device
                    {
                        SerialNumber = "sr-111-AAA",
                        RegistrationDate = Convert.ToDateTime("2/13/2020"),
                        FirmwareVersion = "FV-JKLS"
                    },

                    new Device
                    {
                        SerialNumber = "sr-222-BBB",
                        RegistrationDate = Convert.ToDateTime("2/13/2020"),
                        FirmwareVersion = "SS-KFLJA"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
