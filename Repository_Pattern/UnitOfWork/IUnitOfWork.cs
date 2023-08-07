using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.UnitofWork
{
    public interface IUnitOfWork:IDisposable
    {
        void SaveChanges();
    }
}
