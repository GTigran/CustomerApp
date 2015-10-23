using System.Collections.Generic;
using CustomerManagement.BusinessObjects.Models;
using CustomerManagement.Common.Tools;

namespace CustomerManagement.Core.Abstract.Repositories
{
    /// <summary>
    /// Created db query functionalioty related to customer.
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public interface ICustomerRepository<TContext> : IRepositoryBase<TContext>
    {
        CustomerModel GetCustomerByID(int id);
        
        IList<CustomerModel> GetCustomerList(GetListModel getListModel);

        ResponseResult UpsertCustomer(CustomerModel model);

        ResponseResult DeleteCustomer(int id);
    }
}
