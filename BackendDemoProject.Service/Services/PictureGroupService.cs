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
    public class PictureGroupService : Service<PictureGroup>, IPictureGroupService
    {
        public PictureGroupService(IUnitOfWork unitOfWork, IRepository<PictureGroup> repository) : base(unitOfWork, repository)
        {
        }
    }
}
