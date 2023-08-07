using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext dbContext;
        public UnitOfWork(DbContext context)
        {
            dbContext = context;
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}
