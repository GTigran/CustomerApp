using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BusinessObjects.Models
{
    public class CustomerModel:IIdentityModel,ITrackableModel
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        public string CompanyName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        

    }
}
