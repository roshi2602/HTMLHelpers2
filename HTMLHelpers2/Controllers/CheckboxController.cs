using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers2.Models;
namespace HTMLHelpers2.Controllers
{
    public class CheckboxController : Controller
    {
        // GET: Checkbox
        [HttpGet]
        public ActionResult MyIndex()
        {
            Checkbox cb = new Checkbox();
            return View(cb);
        }

 

    }
}