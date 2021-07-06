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
    public class MaintenanceService : Service<Maintenance>, IMaintenanceService
    {
        public MaintenanceService(IUnitOfWork unitOfWork, IRepository<Maintenance> repository) : base(unitOfWork, repository)
        {
        }
    }
}
