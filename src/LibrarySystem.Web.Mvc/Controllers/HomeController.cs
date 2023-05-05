using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibrarySystem.Controllers;

namespace LibrarySystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LibrarySystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
