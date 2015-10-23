using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.BusinessObjects.Models;
using CustomerManagement.DataAccess.EF;

namespace CustomerManagement.Core.Tools
{
    public static class ModelFactory
    {
        /// <summary>
        /// Getcusmtomer db object from business object
        /// </summary>
        /// <param name="model"></param>
        /// <param name="dbObject"></param>
        /// <returns></returns>
        public static Customer ToDbObject(CustomerModel model,Customer dbObject = null)
        {

            var isNewObject = model.ID == 0;

            if (isNewObject)
            {

                dbObject = new Customer
                {
                    CompanyName = model.CompanyName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };
            }
            else if(dbObject!=null)
            {
                dbObject.CompanyName = model.CompanyName;
                dbObject.FirstName= model.FirstName;
                dbObject.LastName = model.LastName;
                dbObject.DateModified = DateTime.UtcNow;
            }

            return dbObject;
        }


        /// <summary>
        /// creates customer model object from db object
        /// </summary>
        /// <param name="dbModel"></param>
        /// <returns></returns>
        public static CustomerModel FromDbObject(Customer dbModel )
        {
            var customerModel = new CustomerModel
            {
                ID =  dbModel.ID,
                FirstName = dbModel.FirstName,
                LastName = dbModel.LastName,
                CompanyName = dbModel.CompanyName,
                DateCreated = dbModel.DateCreated,
                DateModified = dbModel.DateModified
            };


            return customerModel;



        }


        
    }
}
