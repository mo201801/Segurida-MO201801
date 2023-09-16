using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Segurida_MO201801.Controllers
{
    [Authorize(Users ="mo201801@upes.edu.sv")]

    public class SecretController : Controller
    {
        // GET: Secret
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ContentResult Secret()
        {
            return Content("Informacion Secreta aca");
        }

        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Modo Publico");
        }
    }
}