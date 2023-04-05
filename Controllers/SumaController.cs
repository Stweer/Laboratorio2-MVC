using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_QuispeA.Models;

namespace Laboratorio2_QuispeA.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSuma()
        {
            ClsSuma objSuma = new ClsSuma();

            objSuma.num1 = Convert.ToDouble(Request.Form["valor1"]);
            objSuma.num2 = Convert.ToDouble(Request.Form["valor2"]);

            objSuma.resultado = objSuma.num1 + objSuma.num2;

            return View(objSuma);
        }
    }
}