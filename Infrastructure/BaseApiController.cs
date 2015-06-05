using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;


namespace ASP.NET_MVC5_Bootstrap_3._3._4_LESS1.Infrastructure
{
    //public class BaseApiController : Controller
    //{

    //    private ModelFactory _modelFactory;
    //    private ApplicationUserManager _AppUserManager = null;
    //    private ApplicationRoleManager _AppRoleManager = null;

    //    protected ApplicationUserManager AppUserManager
    //    {
    //        get
    //        {
    //            return _AppUserManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
    //        }
    //    }

    //    protected ApplicationRoleManager AppRoleManager
    //    {
    //        get
    //        {
    //            return _AppRoleManager ?? Request.GetOwinContext().GetUserManager<ApplicationRoleManager>();
    //        }
    //    }

    //    public BaseApiController()
    //    {
    //    }

    //    protected ModelFactory TheModelFactory
    //    {
    //        get
    //        {
    //            if (_modelFactory == null)
    //            {
    //                _modelFactory = new ModelFactory(this.Request, this.AppUserManager);
    //            }
    //            return _modelFactory;
    //        }
    //    }

    //    protected IHttpActionResult GetErrorResult(IdentityResult result)
    //    {
    //        if (result == null)
    //        {
    //            return InternalServerError();
    //        }

    //        if (!result.Succeeded)
    //        {
    //            if (result.Errors != null)
    //            {
    //                foreach (string error in result.Errors)
    //                {
    //                    ModelState.AddModelError("", error);
    //                }
    //            }

    //            if (ModelState.IsValid)
    //            {
    //                // No ModelState errors are available to send, so just return an empty BadRequest.
    //                return BadRequest();
    //            }

    //            return BadRequest(ModelState);
    //        }

    //        return null;
    //    }
    //}
}
