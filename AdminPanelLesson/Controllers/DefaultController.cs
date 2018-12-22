using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AdminPanelLesson.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            return File(@"C:\Users\ПавловЕ\Downloads\parallax.js-1.5.0.zip", "application/zip");
        }
    }
}