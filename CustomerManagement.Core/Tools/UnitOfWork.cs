using CustomerManagement.Core.Abstract.Repositories;
using CustomerManagement.Core.Abstract.Tools;
using CustomerManagement.Core.Repositories;
using CustomerManagement.DataAccess.EF;

namespace CustomerManagement.Core.Tools
{
    public class UnitOfWork :IUnitofWork<CustomerManagementDBEntities>
    {
        #region ctor

        public UnitOfWork()
        {
            DbContext = new CustomerManagementDBEntities();
        }


        #endregion ctor

        #region Repositories

        private ICustomerRepository<CustomerManagementDBEntities> _customerRepository;

        public ICustomerRepository<CustomerManagementDBEntities>
            CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(DbContext);
                }


                return _customerRepository;
            }
            
        }

        #endregion

        #region Idisposable Implt

        public void Dispose()
        {
            DbContext.Dispose();
        }

        #endregion Idisposable Implt

        #region IUnitofWork Impl
        public CustomerManagementDBEntities DbContext { get; set; }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        #endregion IUnitofWork Impl

    }
}
