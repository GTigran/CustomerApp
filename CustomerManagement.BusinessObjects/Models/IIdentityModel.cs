using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BusinessObjects.Models
{
    public interface IIdentityModel
    {
        int ID { get; set; }
    }
}
