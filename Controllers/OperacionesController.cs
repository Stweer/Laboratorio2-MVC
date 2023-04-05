using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_QuispeA.Models;

namespace Laboratorio2_QuispeA.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularOperaciones(ClsOperaciones objOpereraciones)
        {
            //ClsSuma objSuma = new ClsSuma();

            //objOpereraciones.num1 = Convert.ToDouble(Request.Form["num1"]);
            //objOpereraciones.num2 = Convert.ToDouble(Request.Form["num2"]);

            if (objOpereraciones.tipo.Equals("S"))
            {
                objOpereraciones.resultado = objOpereraciones.num1 + objOpereraciones.num2;

            }
            else if (objOpereraciones.tipo.Equals("R"))
            {
                objOpereraciones.resultado = objOpereraciones.num1 - objOpereraciones.num2;

            }
            else if (objOpereraciones.tipo.Equals("M"))
            {
                objOpereraciones.resultado = objOpereraciones.num1 + objOpereraciones.num2;

            }
            else
            {
                objOpereraciones.resultado = objOpereraciones.num1 / objOpereraciones.num2;
            }
            return View(objOpereraciones);
        }
    }
}