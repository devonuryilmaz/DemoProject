using BackendDemoProject.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Rollback()
        {
            await _appDbContext.DisposeAsync().ConfigureAwait(false);
        }
    }
}
