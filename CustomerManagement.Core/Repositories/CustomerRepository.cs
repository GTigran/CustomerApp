using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.BusinessObjects.Models;
using CustomerManagement.Common.Tools;
using CustomerManagement.Core.Abstract.Repositories;
using CustomerManagement.Core.Tools;
using CustomerManagement.DataAccess.EF;

namespace CustomerManagement.Core.Repositories
{
    public class CustomerRepository:BaseRepository<CustomerManagementDBEntities>,ICustomerRepository<CustomerManagementDBEntities>
    {
        public CustomerRepository(CustomerManagementDBEntities dbContext) : base(dbContext)
        {

        }


        /// <summary>
        /// Gets customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CustomerModel GetCustomerByID(int id)
        {
            return DbContext.Customers.Where(a => a.ID == id).AsEnumerable()
                .Select(ModelFactory.FromDbObject).Single();
        }


        /// <summary>
        /// Gets customer list
        /// </summary>
        /// <param name="listModel"></param>
        /// <returns></returns>
        public IList<CustomerModel> GetCustomerList(GetListModel listModel)
        {
            return DbContext.Customers.OrderBy(a=>a.ID).Skip(listModel.StartIndex).Take(listModel.PageSize).AsEnumerable()
                .Select(ModelFactory.FromDbObject).ToList();

        }

        /// <summary>
        /// Insrets or updates customer based on condition.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ResponseResult UpsertCustomer(CustomerModel model)
        {
            
            var dbElement = model.ID > 0
                ? DbContext.Customers.Single(a => a.ID == model.ID)
                : null;
            dbElement = ModelFactory.ToDbObject(model,dbElement);


            if (model.ID == 0)
            {
                DbContext.Customers.Add(dbElement);
            }
           
            return new ResponseResult();
        }

        /// <summary>
        /// Deletes customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ResponseResult DeleteCustomer(int id)
        {
            var dbObject = DbContext
                .Customers.Single(a => a.ID == id);

            DbContext.Customers.Remove(dbObject);


            return new ResponseResult();
        }

    }
}
