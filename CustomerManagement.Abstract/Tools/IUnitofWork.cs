using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Core.Abstract.Tools
{
    public interface IUnitofWork<TContext>:IDisposable
    {
     //   TContext DbContext { get; set; }

        int SaveChanges();

    }
}
