using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BusinessObjects.Models
{
    public interface ITrackableModel
    {
        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; }

    }
}
