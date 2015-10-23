using System.Web.Http;
using System.Web.Mvc;
using CustomerManagement.Core.Tools;

namespace CustomerManagement.Web.Common.Tools
{
    public class BaseController : Controller
    {
        public UnitOfWork UnitOfWork = new UnitOfWork();


        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            UnitOfWork.SaveChanges();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            UnitOfWork.Dispose();
        }
    }


    public class BaseApiController : ApiController
    {
        public UnitOfWork UnitOfWork = new UnitOfWork();


        protected int SaveChanges()
        {
            return UnitOfWork.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            SaveChanges();
            UnitOfWork.Dispose();
        }
    }

    
}
