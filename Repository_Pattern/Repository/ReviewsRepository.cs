using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository
{
    public class ReviewsRepository : RepositoryBase<Reviews>
    {
        public ReviewsRepository(DbContext context) : base(context)
        {
        }
    }
}
