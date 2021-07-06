using BackendDemoProject.Core.Entities;
using BackendDemoProject.Core.Repositories;
using BackendDemoProject.Core.Services;
using BackendDemoProject.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Service.Services
{
    public class VehicleTypeService : Service<VehicleType>, IVehicleTypeService
    {
        public VehicleTypeService(IUnitOfWork unitOfWork, IRepository<VehicleType> repository) : base(unitOfWork, repository)
        {
        }
    }
}
