using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaNuevasAltas.Models
{
    public class FormaPago
    { 
        public int Id { get; set; }
        public string Estandar { get; set; }
        public string DatosManual { get; set; }
        public string AdmiteBarra { get; set; }

    }
}
