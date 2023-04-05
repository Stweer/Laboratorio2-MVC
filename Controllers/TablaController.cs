using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_QuispeA.Models;

namespace Laboratorio2_QuispeA.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calcular(ClsTabla objTabla)
        {

            return View(objTabla);
        }
    }
}