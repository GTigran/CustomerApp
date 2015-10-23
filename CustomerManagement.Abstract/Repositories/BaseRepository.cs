using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Core.Abstract.Repositories
{
    public abstract class BaseRepository<TContext>:IRepositoryBase<TContext>
    {
        public TContext DbContext { get; set; }


        protected BaseRepository(TContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
