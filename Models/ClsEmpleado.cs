using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2_QuispeA.Models
{
    public class ClsEmpleado
    {
        public String nombre { get; set; }
        public int dia { get; set; }
        public String categoria { get; set; }
        public bool condicion{ get; set; }
        public double sueldo { get; set; }
    }
}