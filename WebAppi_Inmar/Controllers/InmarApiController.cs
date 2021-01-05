using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace WebAppi_Inmar.Controllers
{
    public class InmarApiController : ApiController
    {
        // GET: InmarApi
        public ActionResult Index()
        {
            return View();
        }
    }
}