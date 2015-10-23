using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.BusinessObjects.Models;
using CustomerManagement.Common.Tools;
using CustomerManagement.Web.Common.Tools;

namespace CustomerManagement.Web.Angular.Controllers
{
    public class CustomerInfoController : BaseApiController
    {
        // GET: api/CustomerInfo
        public IEnumerable<CustomerModel> Get()
        {
            return UnitOfWork.CustomerRepository.GetCustomerList(new GetListModel());
        }

        // GET: api/CustomerInfo/5
        public CustomerModel Get(int id)
        {
            return UnitOfWork.CustomerRepository.GetCustomerByID(id);
        }

        // POST: api/CustomerInfo
        public ResponseResult Post([FromBody]CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return UnitOfWork.CustomerRepository.UpsertCustomer(model);
            }

            return new ResponseResult(false);
        }

        // PUT: api/CustomerInfo/5
        public ResponseResult Put([FromBody]CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return UnitOfWork.CustomerRepository.UpsertCustomer(model);
            }

            return new ResponseResult(false);
        }

        // DELETE: api/CustomerInfo/5
        public ResponseResult Delete(int id)
        {
            return UnitOfWork.CustomerRepository.DeleteCustomer(id);
        }
    }
}
