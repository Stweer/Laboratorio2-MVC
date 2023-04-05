using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_QuispeA.Models;

namespace Laboratorio2_QuispeA.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(ClsEmpleado objEmpleado)
        {
            //ClsSuma objSuma = new ClsSuma();

            //objOpereraciones.num1 = Convert.ToDouble(Request.Form["num1"]);
            //objOpereraciones.num2 = Convert.ToDouble(Request.Form["num2"]);

            double var = 0;

            if (objEmpleado.categoria.Equals("M"))
            {
                var = 30 * objEmpleado.dia;
                if(objEmpleado.condicion == true)
                {
                    objEmpleado.sueldo = var + (var * 0.20);
                }
                else
                {
                    objEmpleado.sueldo = var + (var * 0.10);
                }
                           
            }
            else if (objEmpleado.categoria.Equals("O"))
            {
                var = 25 * objEmpleado.dia;
                if (objEmpleado.condicion == true)
                {
                    objEmpleado.sueldo = var + (var * 0.20);
                }
                else
                {
                    objEmpleado.sueldo = var + (var * 0.10);
                }
            }        
            else
            {
                var = 20 * objEmpleado.dia;
                if (objEmpleado.condicion == true)
                {
                    objEmpleado.sueldo = var + (var * 0.20);
                }
                else
                {
                    objEmpleado.sueldo = var + (var * 0.10);
                }
            }
            return View(objEmpleado);
        }

    }
}