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
    public class MaintenanceHistoryService : Service<MaintenanceHistory>, IMaintenanceHistoryService
    {
        public MaintenanceHistoryService(IUnitOfWork unitOfWork, IRepository<MaintenanceHistory> repository) : base(unitOfWork, repository)
        {
        }
    }
}
