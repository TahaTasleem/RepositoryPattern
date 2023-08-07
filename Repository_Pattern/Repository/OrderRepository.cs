using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }
    }
}
