using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theorem_ACPrototype_WebAPI.Models;

namespace Theorem_ACPrototype_WebAPI.Repository.EFCore
{
    public class EfCoreDeviceRepository : EfCoreRepository<Device, DeviceContext>
    {
        public EfCoreDeviceRepository(DeviceContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
